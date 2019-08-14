using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public struct Status
    {
        public string playername;
        public int interval;
        public int mode;
        public int size;
        public Status(string name, int t, int m, int s)
        {
            playername = name;
            interval = t;
            mode = m;
            size = s;
        }
        Status(Status a)
        {
            playername = a.playername;
            interval = a.interval;
            mode = a.mode;
            size = a.size;
        }
    }
}
