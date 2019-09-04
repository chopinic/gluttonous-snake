using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    class Score
    {
        private int length = 0;
        private string playerName = "";
        public void Clone(Score t) { length = t.length;playerName = t.playerName; }
        public void setPlayerName(string t) { playerName = t; }
        public string getPlayerName() { return playerName; }
        public int getLength() { return length; }
        public void setLength(int t) { length = t; }
        public bool compare(Score t) { return t.length < length; }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
