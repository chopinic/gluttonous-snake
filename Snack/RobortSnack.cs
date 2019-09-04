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
        face[] step = new face[100];
        int nstep = 0, ntstep = 0;
        face[] tstep = new face[100];
        ArrayList vbody = new ArrayList();
        int[,] map1 = new int[GamePage.maxW+1, GamePage.maxW+1];
        

        public override bool Walk()
        {

            face turnto;
            if (nstep>0)
            {
                nstep--;
                turnto = step[nstep];
                return base.Walk();
            }
            tstep = new face[100];
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
            if (BFS(body[body.Count-1] as Position,food,step,body,vbody)>0)
            {
                if (BFS(vbody[vbody.Count - 1] as Position, vbody[0] as Position, tstep, vbody) > 0)
                {
                    nstep--;
                    turnto = step[nstep];
                    return base.Walk();
                }
            }
            Position t = new Position(head);
            foreach(face i in Enum.GetValues(typeof(face)))
            {
                t = head;
                if (this.ContrastFace(dirc, i) == false)
                    continue;
                if (t.next(i)&&t.mapValue()!=2)
                {
                    nstep--;
                    turnto = i;
                    return base.Walk();
                }
            }

            return base.Walk();



        }
        public int BFS(Position s, Position e, face[] steps, ArrayList body)
        {
            return 0;
        }

        public bool vbodyClash(ArrayList body,Position tt)
        {
            for (int ii = 0; ii < body.Count; ii++)
            {
                Position now = body[ii] as Position;
                if (now.x == tt.x && now.y == tt.y)
                {
                    if (ii <= tt.step)
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
            ArrayList c = new ArrayList();
            s.step = 0;s.prevnum = -1;
            o.Enqueue(s);
            Position t,tt;
            int nstep = 0;
            while(o.Count!=0)
            {
                t = o.Dequeue();
                int prevn = c.Count;
                c.Add(new Position(t));
                if(t.x == e.x&&t.y == e.y)
                {
                    while(t.prevnum!=-1)
                    {
                        steps[nstep++] = t.turn;
                        t = c[t.prevnum] as Position;
                    }
                }
                foreach (face i in Enum.GetValues(typeof(face)))
                {
                    tt = new Position(t);
                    tt.step++;
                    tt.prevnum = prevn;
                    if (this.ContrastFace(dirc, i) == false)
                        continue;
                    if (tt.next(i))
                    {
                        if(tt.mapValue()==2)
                        {
                            if (vbodyClash(body, tt) == true)
                                continue;
                        }
                        tt.turn = i;
                        o.Enqueue(tt);
                    }
                }
            }


        }
    }

}
