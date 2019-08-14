using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class Scores
    {
        int total = 0;
        Score[] scores = new Score[10];
        public bool add(Score t)
        {
            bool breaking= false;
            if(total < 10)
            {
                scores[total] = new Score();
                total++;
            }
            for (int i = 0; i < total; i++)
            {
                if(t.compare(scores[i])==true)
                {
                    if(i == 0)breaking = true;
                    for (int ii = total-1 ; ii > i; ii--)
                        scores[ii].Clone(scores[ii - 1]);
                    scores[i].Clone(t);
                    break;
                }
            }
            return breaking;
            
        }
        public string showLength()
        {
            string r = "";
            foreach(Score i in scores)
            {
                if (i != null)
                {
                    r = r + i.getLength();
                    r += "\r\n";
                    

                }
            }
            return r;
        }
        public string showName()
        {
            string namer = "";
            foreach (Score i in scores)
            {
                if (i != null)
                {
                    namer = namer + i.getPlayerName();
                    namer += "\r\n";


                }
            }
            return namer;
        }

    }
    
}
