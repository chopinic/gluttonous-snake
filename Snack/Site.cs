using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Site:ICloneable
    {
        protected int x, y;

        public object Clone()
        {
            Site t = new Site();
            return t;
        }
    }
}
