using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{


    public partial class Position 
    {
        public int x, y;
        private int num;
        private int step = 0;
        public Position() { }
        public Position(Position t)
        {
            this.x = t.x; this.y = t.y;
            step = t.step;
        }
        public Position(int t) { this.x = t / 10; y = (t % 10); }
        public void stepp() { step++; }
        public void setStep(int t) { step = t; }
        public void setNum() { num++; }
        public void setNum(int n) { num = n; }
        public int getNum() { return num; }
        public int getStep() { return step; }
        public bool compare(Position t) { return (x == t.x) && (y == t.y); }
        public bool next(face t)
        {
            Position tt = new Position(this);
            if (t == face.down)
                tt.x -= 1;
            if (t == face.up)
                tt.x += 1;
            if (t == face.left)
                tt.y -= 1;
            if (t == face.right)
                tt.y += 1;
            if (tt.x < GamePage.maxW && tt.x > 0 && tt.y < GamePage.maxH && tt.y > 0)
            {
                this.x = tt.x;this.y = tt.y;
                return true;
            }
            else
                return false;
        }
        
        public int mapValue()
        {
            return GamePage.map[x, y];
        }
        public int mapValue(int[,] map)
        {
            return map[x, y];
        }
        public int getx() { return x; }
        public int gety() { return y; }
        

        

       
    }
}
