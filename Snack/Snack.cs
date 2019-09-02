using System;
using System.Windows;
using System.Collections;
namespace WindowsFormsApp1
{
    public class Snack
    {
        protected bool isAlive = true;
        protected static face dirc = face.up;
        protected static ArrayList footPrint = new ArrayList();
        protected int length = 1;
        protected int nowSite = 0;
        public Snack() { footPrint.Clear(); Position now = new Position(55);footPrint.Add(now);  dirc = face.up; }
        public static face getdirc() { return dirc; }
        public static void  setdirc(face a) { dirc = a; }
        public int getLength() { return length; }
        virtual public bool Walk()
        {
            Position now = new Position(footPrint[length - 1] as Position);
            Position t = new Position();
            if (now.next(dirc))
            {
                if (now.mapValue() == 3)
                {
                    length++;
                    footPrint.Add(now);
                    GamePage.map[now.x, now.y] = 2;
                    GamePage.newFood();

                }
                else if (now.mapValue()==2)
                {
                    isAlive = false;
                }
                else
                {
                    footPrint.Add(now);
                    GamePage.map[now.x, now.y] = 2;
                    t = (Position)footPrint[0];
                    GamePage.map[t.x, t.y] = 1;
                    footPrint.RemoveAt(0);
                }
            }
            else
                isAlive = false;
            return isAlive;
        }
        public bool ContrastFace(face a, face b)
        {
            if ((a == face.up && b == face.down) || (a == face.down && b == face.up)
                || (a == face.left && b == face.right)
                || (a == face.right && b == face.left))
                return false;
            else
                return true;
        }

    }
}
