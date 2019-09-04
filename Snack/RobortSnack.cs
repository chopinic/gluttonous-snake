using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RobortSnack : Snack
    {
        face[] step = new face[450];
        int nstep = 0, ntstep = 0;
        face[] tstep = new face[450];
        ArrayList vbody = new ArrayList();
        int[,] map1 = new int[GamePage.maxW+1, GamePage.maxW+1];
        public override void setdirc(face a) { return; }
        public override bool Walk()
        {
            if (nstep>0)
            {
                nstep--;
                dirc = step[nstep];
                return base.Walk();
            }
            tstep = new face[450];
            Position food = new Position();
            //Position head = new Position()
            Position head = new Position(body[body.Count - 1] as Position);

            for (int i = 0; i <GamePage.maxH; i++)
            {
                for (int j = 0; j < GamePage.maxH; j++)
                {
                    if(GamePage.map[i,j]==3)
                    {
                        food.x = i; food.y = j;
                        break;
                    }
                }

            }
            int findfood = BFS(body[body.Count - 1] as Position, food, step, body, vbody);
            int findtail;
            if (vbody.Count != 0)
                findtail = BFS(vbody[vbody.Count - 1] as Position, vbody[0] as Position, tstep, vbody);
            else
                findtail = 0;
            if (findfood>0&& (findtail > 0||vbody.Count==1))
            {
                nstep = findfood;
                nstep--;
                dirc = step[nstep];
                return base.Walk();
            }
            findtail  = BFS(body[body.Count - 1] as Position, body[0]as Position, step, body);
            if (findtail>0)
            {
                dirc = step[findtail-1];
                return base.Walk();
            }
            Position t = new Position(head);
            int max = 0;
            foreach(face i in Enum.GetValues(typeof(face)))
            {
                t = head;
                if (this.ContrastFace(dirc, i) == false)
                    continue;
                if (t.next(i)&&t.mapValue()!=2)
                {
                    if(t.distance(body[0]as Position)>max)
                    {
                        max = t.distance(body[0] as Position);
                        dirc = i;
                    }
                }
            }
            return base.Walk();




        }
        public int BFS(Position s, Position e, face[] steps, ArrayList body)
        {
            bool[,] vis = new bool[25, 25];
            Queue<Position> o = new Queue<Position>();
            ArrayList c = new ArrayList();
            s.step = 0; s.prevnum = -1;
            o.Enqueue(s);
            Position t, tt;
            int nstep = 0;
            while (o.Count != 0)
            {
                t = o.Dequeue();
                int prevn = c.Count;
                c.Add(new Position(t));
                if (t.x == e.x && t.y == e.y)
                {
                    while (t.prevnum != -1)
                    {
                        steps[nstep++] = t.turn;
                        t = c[t.prevnum] as Position;
                    }
                    return nstep;
                }
                foreach (face i in Enum.GetValues(typeof(face)))
                {
                    tt = new Position(t);
                    tt.step++;
                    tt.prevnum = prevn;
                    if (this.ContrastFace(t.turn, i) == false)
                        continue;
                    if (tt.next(i)&&vis[tt.x, tt.y] == false)
                    {
                        if (vbodyClash(body, tt) == true)
                        {
                            continue;
                        }
                        tt.turn = i;
                        vis[tt.x, tt.y] = true;
                        o.Enqueue(new Position( tt));
                    }
                }
            }
            return nstep;
        }

        public bool vbodyClash(ArrayList body,Position tt)
        {
            for (int ii = 0; ii < body.Count; ii++)
            {
                Position now = body[ii] as Position;
                if (now.x == tt.x && now.y == tt.y)
                {
                    if (ii < tt.step-1)
                    {
                        return false;//不冲突
                    }
                    return true;
                }
            }
            return false;//不冲突
        }
        public int BFS(Position s,Position e,face[] steps, ArrayList body, ArrayList afterbody)
        {
            Queue<Position> o = new Queue<Position>();
            bool[,] vis = new bool[25, 25];
            ArrayList c = new ArrayList();
            s.step = 0;s.prevnum = -1;
            s.turn = dirc;
            o.Enqueue(s);
            Position t,tt;
            int nstep = 0;
            vbody = new ArrayList();
            while(o.Count!=0)
            {
                t = o.Dequeue();
                int prevn = c.Count;
                c.Add(new Position(t));
                if(t.x == e.x&&t.y == e.y)
                {
                    int cot = 0;
                    while(t.step!=0)
                    {
                        if (cot < this.length)
                        {
                            vbody.Add(new Position(t));
                        }
                        cot++;
                        steps[nstep++] = t.turn;
                        t = c[t.prevnum] as Position;
                    }
                    int ccot = 1;
                    while (cot<length)
                    {
                        vbody.Add(body[body.Count - ccot]);
                        ccot++;
                        cot++;
                    }
                    vbody.Reverse();
                    return nstep;
                }
                foreach (face i in Enum.GetValues(typeof(face)))
                {
                    tt = new Position(t);
                    tt.step++;
                    tt.prevnum = prevn;
                    if (this.ContrastFace(t.turn, i) == false)
                        continue;
                    if (tt.next(i))
                        if(vis[tt.x, tt.y] == false)
                    {
                        if(vbodyClash(body, tt) == true)
                        {
                            continue;
                        }
                        tt.turn = i;
                        vis[tt.x, tt.y] = true;
                        o.Enqueue(new Position(tt));
                    }
                }
            }
            return nstep;

        }
    }

}
