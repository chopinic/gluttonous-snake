using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RobortSnack : Snack
    {
        public Queue<int> body;
        int stepcot = 0;
        int[,] map1 = new int[mainForm.maxW+1, mainForm.maxW+1];
        

        public override bool Walk()
        {

            face toface;
            if (step == null || step.Count == 0)
            {
                BFS();
                //if (isAlive == false)
                //    return isAlive;
            }
            if (step.Count != 0)
            {
                toface = step.Pop();
                stepcot--;
                dirc = toface;
            }
            return base.Walk();
           
        }

        public int BFS()
        {
            Console.WriteLine("flag1");

            reach = 0;
            int[,] vis = new int[mainForm.maxW+1, mainForm.maxW+1];
            for (int i = 0; i < mainForm.maxW; i++)
                for (int ii = 0; ii < mainForm.maxW; ii++)
                    vis[i, ii] = mainForm.maxW * mainForm.maxH;
            body = new Queue<int>();
            bool find = false;
            Stack<Position> close = new Stack<Position>();
            step = new Stack<face>();
            Queue<Position> q = new Queue<Position>();
            int cot = 0;
            map1 = new int[mainForm.maxH+1, mainForm.maxW+1];
            for (int i = length - 1; i >= 0; i--)
            {
                map1[footPrint[((nowSite - i) % (mainForm.maxW * mainForm.maxW))].getx(),
                    footPrint[((nowSite - i) % (mainForm.maxW * mainForm.maxW))].gety()] = length - i;
            }
            Position t = footPrint[nowSite % (mainForm.maxW * mainForm.maxW)];
            if (nowSite > 0)
                t.Prev(footPrint[(nowSite - 1) % (mainForm.maxW * mainForm.maxW)]);
            q.Enqueue(new Position(t)); cot++;
            vis[t.getx(), t.gety()] = t.getStep();
            Position tt = new Position();
            int nowTotal = 1;
            Console.WriteLine("flag3");

            while (cot != 0)
            {
                t = q.Dequeue();
                close.Push(t);
                cot--;
               
                foreach (face f in Enum.GetValues(typeof(face)))
                {
                    tt = (Position)t.Clone();
                    tt.Prev(t); tt.stepp();
                    tt.setNum(nowTotal); tt.setPreNum(t.getNum());
                    if (tt.walk(f))
                    {
                        if (ContrastFace(f, t.compareTurn()) == false)
                            continue;
                        if (map1[tt.getx(), tt.gety()] >= tt.getStep() 
                            || vis[tt.getx(), tt.gety()] <= tt.getStep())
                            continue;
                        vis[tt.getx(), tt.gety()] = tt.getStep();
                        
                        q.Enqueue(new Position(tt));

                        nowTotal++;
                        cot++;

                        if (tt.mapValue() == 3)
                        {


                                #region 获取路径
                                Position t1 = new Position(); t1 = (Position)tt.Clone();
                                track = new Position[mainForm.maxW * mainForm.maxW];
                                int[,] map2 = new int[mainForm.maxW, mainForm.maxW];
                                int nows = 0; int viscot = 0;
                                Queue<Position> vert = new Queue<Position>();
                                step = new Stack<face>();
                            step.Push(t1.compareTurn());
                            while (t1.getNum() != 0)
                            {
                                track[nows] = new Position(t1); nows++;
                                foreach (Position i in close)
                                {
                                    if (t1.compareDerive(i))
                                    {
                                        t1 = (Position)i.Clone();
                                        step.Push(t1.compareTurn());
                                        break;
                                    }
                                }
                            }
                            step.Pop();
                            #endregion
                            Console.WriteLine("flag3:next");

                            if (mainForm.maxH < 14)
                            {
                                #region map2标记蛇体
                                for (int i = 0; i < length + 1 - nows; i++)
                                {
                                    map2[footPrint[(nowSite - i) % (mainForm.maxW * mainForm.maxW)].getx(),
                                        footPrint[(nowSite - i) % (mainForm.maxW * mainForm.maxW)].gety()] = nows + i + 1;
                                }
                                for (int i = 0; i < nows && i < length + 1; i++)
                                {
                                    map2[track[i].getx(), track[i].gety()] = i + 1;
                                }

                                #endregion
                                #region 验证答案BFS


                                t1 = (Position)tt.Clone();
                                t1.setStep(0);
                                vert.Enqueue(new Position(t1));
                                Position t2 = new Position();
                                while (vert.Count != 0)
                                {
                                    t1 = vert.Dequeue();

                                    foreach (face k in Enum.GetValues(typeof(face)))
                                    {

                                        t2 = (Position)t1.Clone(); t2.stepp(); t2.Prev(t1);
                                        if (t2.walk(k))
                                        {
                                            if (ContrastFace(t1.compareTurn(), k) == false)
                                                continue;
                                            if (t2.mapValue(map2) == -1 || t2.mapValue(map2) > t2.getStep())
                                                continue;
                                            vert.Enqueue(new Position(t2));
                                            map2[t2.getx(), t2.gety()] = -1;
                                            viscot++;
                                        }
                                    }
                                }
                                #endregion
                                reach = viscot;
                                if (reach >= (mainForm.maxW * mainForm.maxW))
                                {
                                    find = true;
                                    break;

                                }

                            }
                            else
                            {
                                find = true;
                                Console.WriteLine("flag4");

                                break;
                            }



                        }

                    }
                }
                if (find)
                    break;
            }
            if (cot == 0 && find == false)
            {
                isAlive = false;
            }
            t = tt;
            //while (t.compare(footPrint[nowSite %  (Form1.maxW * Form1.maxW)]) == false)
            //{
            //    step.Push(t.compareTurn());
            //    stepcot++;
            //    t.reverse();
            //    tt = close.Pop();
            //    while (t.compare(tt) == false) { tt = close.Pop(); }
            //    t.setSite(tt);
            //}
            return reach;
        }
        #region DFS

        public int[,] DFSvis = new int[mainForm.maxW+1, mainForm.maxW+1];
        public int nowstep;
        public int minstep;
        public Stack<face> DFSstep;
        public bool find = false;
        public void GoTo(Position a)
        {
            if (a.mapValue() == 3)
            {
                find = true;
                if (minstep > nowstep)
                {
                    minstep = nowstep;
                    find = true;
                    while (step.Count > 0) step.Pop();
                    foreach (face i in DFSstep) step.Push(i);

                }
                return;
            }

            Position t = new Position();
            foreach (face f in Enum.GetValues(typeof(face)))
            {
                t= (Position)a.Clone();
                t.Prev(a); t.stepp();
                if (t.walk(f))
                {
                    if ((DFSvis[t.getx(), t.gety()] <= length && DFSvis[t.getx(), t.gety()] >= t.getStep())
                        || DFSvis[t.getx(), t.gety()] > length || nowstep + 1 > minstep)
                        continue;
                    nowstep++;
                    int prevalue = DFSvis[t.getx(), t.gety()];
                    DFSvis[t.getx(), t.gety()] = nowstep;
                    DFSstep.Push(t.compareTurn());
                    GoTo(t);
                    DFSstep.Pop();
                    DFSvis[t.getx(), t.gety()] = prevalue;
                    nowstep--;

                }
            }
        }
        public void DFS()
        {
            step = new Stack<face>();
            DFSstep = new Stack<face>();
            for (int i = 0; i < mainForm.maxH; i++)
                for (int ii = 0; ii < mainForm.maxW; ii++)
                    DFSvis[i, ii] = 0;
            nowstep = length;
            minstep = length * 2;
            if (minstep < 20)
                minstep = 20;

            find = false;
            for (int i = length - 1; i >= 0; i--)
            {
                DFSvis[footPrint[((nowSite - i) % (mainForm.maxW * mainForm.maxW))].getx(),
                    footPrint[((nowSite - i) % (mainForm.maxW * mainForm.maxW))].gety()] = length - i;

            }
            GoTo(footPrint[nowSite % (mainForm.maxW * mainForm.maxW)]);
            if (find == false)
                return;
        }
        #endregion
    }

}
