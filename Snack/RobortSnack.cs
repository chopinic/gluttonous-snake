using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class RobortSnack : Snack
    {
        protected Stack<face> step;
        public Queue<int> body;
        int stepcot = 0;
        int[,] map1 = new int[GamePage.maxW+1, GamePage.maxW+1];
        

        public override bool Walk()
        {

            face toface;
            if (step == null || step.Count == 0)
            {
                BFS();
            }
            if (step.Count != 0)
            {
                toface = step.Pop();
                stepcot--;
                dirc = toface;
            }
            return base.Walk();
           
        }

        public void BFS()
        {
            
        }
    }

}
