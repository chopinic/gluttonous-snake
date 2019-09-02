using System;
using System.Windows;
using System.Collections;
namespace WindowsFormsApp1
{
    public class Snack
    {
        protected int reach = 0;
        protected bool isAlive = true;
        protected static face dirc = face.up;
        protected static ArrayList footPrint = new ArrayList();
        protected int length = 1;
        protected int nowSite = 0;
        public Snack() {   dirc = face.up; }
        public static face getdirc() { return dirc; }
        public static void  setdirc(face a) { dirc = a; }
        public int getLength() { return length; }
        virtual public bool Walk()
        {
            Position now = new Position(footPrint[length - 1] as Position);
            if (now.next(dirc))
            {
                if (now.mapValue() == 3)
                {
                    length++;
                }
                else if(footPrint.IndexOf(now)!=-1)
                {
                    isAlive = false;
                }
                else
                    footPrint.RemoveAt(0);
                footPrint.Add(now);
            }
            else
                isAlive = false;
            if (now.mapValue() == 3)
                GamePage.newFood();
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
