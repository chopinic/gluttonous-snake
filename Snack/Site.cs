using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class site:ICloneable
    {
        private int x;
        private int y;
        private int prevx;
        private int prevy;
        private int num;
        private int pren;
        private int step = 0;
        public site() { }
        public site(site t)
        {
            this.x = t.x; this.y = t.y;
            pren = t.pren; num = t.num;
            prevx = t.prevx; prevy = t.prevy;
            step = t.step;

        }
        public site(int t) { this.x = t / 10; y = (t % 10); }
        public void stepp() { step++; }
        public void setStep(int t) { step = t; }
        public void setNum() { num++; }
        public void setNum(int n) { num = n; }
        public void setPreNum(int n) { pren = n; }
        public int getPreNum() { return pren; }
        public int getNum() { return num; }
        public int getStep() { return step; }
        public bool compare(site t) { return (x == t.x) && (y == t.y); }
        public bool compareDerive(site t) { return pren == t.num; }
        public site reverse() { x = prevx; y = prevy; return this; }
        public face compareTurn()
        {
            if (prevx == x && prevy == y)
                return face.up;
            if (x == prevx)
            {
                if (y > prevy)
                    return face.right;
                else
                    return face.left;
            }
            else
            {
                if (x > prevx)
                    return face.up;
                else
                    return face.down;
            }
        }
        public bool walk(face t)
        {
            if (t == face.down)
                x -= 1;
            if (t == face.up)
                x += 1;
            if (t == face.left)
                y -= 1;
            if (t == face.right)
                y += 1;
            if (x < mainForm.maxW && x > 0 && y < mainForm.maxH && y > 0)
                return true;
            else
                return false;
        }
        public void Prev(site t)
        { prevx = t.x; prevy = t.y; }
        public int mapValue()
        {
            return mainForm.map[x, y];
        }
        public int mapValue(int[,] map)
        {
            return map[x, y];
        }
        public int getx() { return x; }
        public int gety() { return y; }
        

        

        public object Clone()
        {
            site t = new site(this);
            return t;
        }
    }
}
