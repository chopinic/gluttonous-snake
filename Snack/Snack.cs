using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Snack
    {
        protected Stack<face> step;
        protected int reach = 0;
        protected Position[] footPrint = new Position[GamePage.maxW * GamePage.maxW]; //十位是行，个位是列
        protected bool isAlive = true;
        protected static face dirc = face.up;
        protected int length = 1;
        protected Position[] track;
        protected int nowSite = 0;
        protected bool changeFood = false;
        public Snack() { Position t = new Position(55); footPrint[0] = t; dirc = face.up; }
        public bool ContrastFace(face a, face b)
        {
            if ((a == face.up && b == face.down) || (a == face.down && b == face.up)
                || (a == face.left && b == face.right)
                || (a == face.right && b == face.left))
                return false;
            else
                return true;
        }
        public static face getdirc() { return dirc; }
        public static void  setdirc(face a) { dirc = a; }
        public int getlength() { return length; }
        virtual public bool Walk()
        {
            nowSite++;
            footPrint[((nowSite) % (GamePage.maxW * GamePage.maxW))] = new Position(footPrint[((nowSite - 1) % (GamePage.maxW * GamePage.maxW))]);
            isAlive = footPrint[(nowSite % (GamePage.maxW * GamePage.maxW))].walk(dirc);
            if (footPrint[(nowSite % (GamePage.maxW * GamePage.maxW))].mapValue() == 2)
            {
                isAlive = false;
            }
            if (!isAlive)
                return false;
            if (GamePage.map[footPrint[(nowSite % (GamePage.maxW * GamePage.maxW))].getx(),
                footPrint[(nowSite % (GamePage.maxW * GamePage.maxW))].gety()] == 3)
            {
                length++;
                changeFood = true;
            }
            for (int i = 0; i < length; i++)
            {
                GamePage.map[footPrint[((nowSite - i) % (GamePage.maxW * GamePage.maxW))].getx(), footPrint[((nowSite - i) % (GamePage.maxW * GamePage.maxW))].gety()] = 2;
            }
            GamePage.map[footPrint[((nowSite - length) % (GamePage.maxW * GamePage.maxW))].getx(),
                footPrint[((nowSite - length) % (GamePage.maxW * GamePage.maxW))].gety()] = 1;
            if (changeFood)
            {
                GamePage.newFood();
                changeFood = false;
            }
            return isAlive;
        }
        public int getLenth() { return length; }
        virtual public int getReach()
        {
            Position tt = new Position();
            tt = (Position)footPrint[nowSite % (GamePage.maxW * GamePage.maxW)].Clone();
            #region 标记蛇体
            int[,] map1 = new int[GamePage.maxW+1,GamePage.maxW+1];
            for (int i = length - 1; i >= 0; i--)
            {
                map1[footPrint[((nowSite - i) % (GamePage.maxW * GamePage.maxW))].getx(),
                    footPrint[((nowSite - i) % (GamePage.maxW * GamePage.maxW))].gety()] = length - i;
            }
            #endregion

            #region BFS获取reach
            reach = 0;
            Position t1 = new Position();
            Queue<Position> vert = new Queue<Position>();
            t1 = (Position)tt.Clone(); ;
            t1.setStep(0);
            if(nowSite>0)
                t1.Prev(footPrint[(nowSite - 1) % (GamePage.maxW * GamePage.maxW)]);
            else { return GamePage.maxW * GamePage.maxW; }
            vert.Enqueue(new Position(t1));
            Position t2 = new Position();
            Console.WriteLine("flag2");
            while (vert.Count != 0)
            {
                t1 = vert.Dequeue();
                foreach (face k in Enum.GetValues(typeof(face)))
                {
                    t2=(Position)(t1).Clone(); t2.Prev(t1); t2.stepp();
                    if (t2.walk(k))
                    {
                        if (ContrastFace(t1.compareTurn(), k) == false)
                            continue;
                        if (t2.mapValue(map1) == -1 || t2.mapValue(map1) > t2.getStep())
                            continue;
                        vert.Enqueue(new Position(t2));
                        map1[t2.getx(), t2.gety()] = -1;
                        reach++;
                        

                    }
                }
            }
            Console.WriteLine("flag2:next");

            #endregion
            return reach;
        }

    }
}
