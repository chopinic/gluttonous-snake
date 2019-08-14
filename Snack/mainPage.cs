using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    
    public partial class mainForm : Form
    {
        Scores scores = new Scores();
        public static int maxH = 20;
        public static int maxW = 20;
        face input = face.down;
        int cot = 3;                //倒计时
        public mainForm()
        {
            InitializeComponent();
            startPage startPage1 = new startPage(this);
            startPage1.TopLevel = false;
            startPage1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(startPage1);
            startPage1.Show();
        }
        private static string result = "";
        int interval=1000;
        public static int[,] map = new int[maxH+2, maxW+2];
        public void showString()
        {
            mapString.Font = new Font(mapString.Font.FontFamily.Name, 9);
            result = "";
            for (int i = 0; i < maxW+1; i++)
            {
                for (int ii = 0; ii < maxW+1; ii++)
                {
                    if (map[i, ii] == 1)
                    {
                        result += "  ";
                    }
                    else if (map[i, ii] == 2)
                    {
                        result += "█";
                    }
                    else if (map[i, ii] == 0)
                    {
                        result += " +";
                    }
                    else
                        result += "★";
                }
                result += "\r\n";
            }
            mapString.Text = result;
        }
        public int[] records = new int[10];
        public static string t = "";
        private void SerializeObj(string filename, Scores t)
        {
            using (FileStream writer
                = new FileStream(filename, FileMode.Create))
            {
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(writer, t);
            }
        }
        private Scores DeserializeObj(string filename)
        {
            try
            {
                using (FileStream reader = new FileStream(filename, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return (Scores)formatter.Deserialize(reader);
                }
            }
            catch (System.IO.FileNotFoundException e)
            {
                SerializeObj("PlayerRecords", scores);
                using (FileStream reader = new FileStream(filename, FileMode.Open))
                {
                    IFormatter formatter = new BinaryFormatter();
                    return (Scores)formatter.Deserialize(reader);
                }
            }
        }
        public static void newFood()
        {
            decimal seed = decimal.Parse(DateTime.Now.Second.ToString());
            int s = (int)seed;
            Random ran = new Random(s);
            int a = ran.Next(1, maxH-1);
            int b = ran.Next(1, maxW-1);
            while (map[a, b] != 1)
            {
                a = ran.Next(1, maxH - 1);
                b = ran.Next(1, maxW - 1);
            }

            map[a, b] = 3;
        }
        public static Position[] food = new Position[15];
        public static int now = 0;
        #region Debug
        public static void newFood(int a)
        {
            while (food[now].mapValue() == 2)
                now++;
            
            map[food[now].getx(), food[now].gety()] = 3;
            now++;
        }
        #endregion
        public void initializeMap()
        {
            now = 0;
            #region Debug

            food[0] = new Position(53);
            food[1] = new Position(31);
            food[2] = new Position(85);
            food[3] = new Position(73);
            food[4] = new Position(18);
            food[5] = new Position(81);
            food[6] = new Position(25);
            food[7] = new Position(74);
            food[8] = new Position(58);
            food[9] = new Position(41);
            food[10] = new Position(26);
            food[11] = new Position(85);
            food[12] = new Position(33);
            food[13] = new Position(55);
            food[14] = new Position(44);
            #endregion 

            for (int i = 0; i < maxH+1; i++)
            {
                map[0, i] = 0;
                map[maxH, i] = 0;
                map[i, 0] = 0;
                map[i, maxW] = 0;
            }
            for (int i = 1; i < maxH ; i++)
            {
                for(int ii = 1; ii < maxH; ii++)
                    map[i,ii]=1; //1 表示区域空
            }
            map[5, 5] = 2;  //2 表示贪食蛇身体
            map[6, 8] = 3;  //3表示食物

        }
        
        
        Snack snack ;
        bool next;
        private void Run(int mode)
        {
            cot = 3;
            if (mode == 1)
            {
                snack = new Snack();
            }
            else
            {
                snack = new RobortSnack();
                playerName.Text = "RobortSnack";
                timer.Interval = 50;
            }
            timer.Interval = interval;
            mapString.Font = new Font(mapString.Font.FontFamily.Name, 60);
            mapString.Text = "\r\n  3";
            timer.Start();
        }
        
        public void Start(Status a)
        {
            panel1.Visible = false;
            interval = a.interval;
            maxH = a.size;
            maxW = a.size;
            playerName.Text = a.playername;
            initializeMap();
            showString();
            Run(a.mode);
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            if (playerName.Text == "RobortSnack")
                playerName.Text = "Player1";
            initializeMap();
            showString();
            Run(1);
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (cot > 1)
            {
                cot--;
                mapString.Text = "\r\n  " + cot.ToString();
                return;
            }
            Snack.dirc = input;
            next = snack.Walk();
            snackLength.Text = "Length: " + snack.getLenth();
            if(next==false)
            {
                timer.Stop();

                Score t = new Score();
                t.setLength(snack.length);t.setPlayerName(playerName.Text);
                if (scores.add(t))
                    mapString.Text += "\r\nYou Break The Record!";
                else
                    mapString.Text += "\r\nYou Fail!";
                SerializeObj("PlayerRecords", scores);
            }
            else
                showString();
            int tt = snack.getReach();
            if (tt != -1)
                reach.Text = tt + " blocks\r\nwithin reach";// + snack.getReach();
            else
                reach.Text = "";
        }
        
        #region 改变时间间隔

        private void SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            interval = 1000;
        }

        private void SToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            interval = 2000;
        }

        private void SToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            interval = 500;
        }

        private void SToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            interval = 300;
        }
        private void SToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            interval = 100;
        }
        #endregion

        private void 手动ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            initializeMap();
            showString();
            playerName.Text = "Player1";
            Run(1);
        }

        private void ToolStripMenuItemAuto_Click(object sender, EventArgs e)
        {
            initializeMap();
            showString();
            Run(2);
        }

        public void ToolStripMenuItemRecords_Click(object sender, EventArgs e)
        {
            scores = DeserializeObj("PlayerRecords");
            Form recordsForm = new Records(scores.showName(),scores.showLength());
            recordsForm.Text = "Records";
            recordsForm.Show();

        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                Pause.Text = "Cintinue";
                timer.Stop();
                timer.Interval = interval;
            }
            else if (snack != null)
            {
                Pause.Text = "Pause";
                timer.Start();
            }

        }

      

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
            {
                if (Snack.dirc != face.down)
                    input = face.up;
            }
            else if (e.KeyChar == 'd')
            {
                if (Snack.dirc != face.left)
                    input = face.right;
            }
            else if (e.KeyChar == 'a')
            {
                if (Snack.dirc != face.right)
                    input = face.left;
            }
            else if (e.KeyChar == 'w')
            {
                if (Snack.dirc != face.up)
                    input = face.down;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            maxH = 11;
            maxW = 11;
            initializeMap();
            showString();
            Run(1);

        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            maxH = 16;
            maxW = 16;
            initializeMap();
            showString();
            Run(1);

        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            maxH = 21;
            maxW = 21;
            initializeMap();
            showString();
            Run(1);

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            timer.Stop();
            startPage startPage1 = new startPage(this);
            startPage1.TopLevel = false;
            startPage1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(startPage1);
            panel1.Visible = true;
            startPage1.Show();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Reach_Click(object sender, EventArgs e)
        {

        }

        private void SnackLength_Click(object sender, EventArgs e)
        {

        }
    }
}
