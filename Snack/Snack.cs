using System;
using System.Windows;
using System.Collections;
namespace WindowsFormsApp1
{
    public class Snack
    {
        protected bool isAlive = true;
        protected  face dirc = face.up;
        protected static ArrayList body = new ArrayList();
        protected int length = 1;
        protected int nowSite = 0;
        public Snack() { body.Clear(); Position now = new Position(55);body.Add(now);  dirc = face.up; }
        public face getdirc() { return dirc; }
        virtual public void  setdirc(face a) { dirc = a; }
        public int getLength() { return length; }
        virtual public bool Walk()
        {
            Position now = new Position(body[length - 1] as Position);
            Position t = new Position();
            if (now.next(dirc))
            {
                if (now.mapValue() == 3)
                {
                    length++;
                    body.Add(now);
                    GamePage.map[now.x, now.y] = 2;
                    GamePage.newFood();

                }
                else if (now.mapValue()==2)
                {
                    isAlive = false;
                }
                else
                {
                    body.Add(now);
                    GamePage.map[now.x, now.y] = 2;
                    t = (Position)body[0];
                    GamePage.map[t.x, t.y] = 1;
                    body.RemoveAt(0);
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
