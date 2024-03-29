﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1 {

    public partial class GamePage : Form {
        Scores scores = new Scores ();
        MainPage main;
        public static int maxH = 20;
        public static int maxW = 20;
        face input = face.down;
        int cot = 3; //倒计时
        public GamePage (MainPage main) {
            InitializeComponent ();
            this.main = main;
        }
        private static string result = "";
        int interval = 1000;
        public static int[, ] map = new int[maxH + 2, maxW + 2];
        public void showString () {
            mapString.Font = new Font (mapString.Font.FontFamily.Name, 9);
            result = "";
            for (int i = 0; i < maxW + 1; i++) {
                for (int ii = 0; ii < maxW + 1; ii++) {
                    if (map[i, ii] == 1) {
                        result += "  ";
                    } else if (map[i, ii] == 2) {
                        result += "█";
                    } else if (map[i, ii] == 0) {
                        result += " +";
                    } else
                        result += "★";
                }
                result += "\r\n";
            }
            mapString.Text = result;
        }
        public int[] records = new int[10];
        public static string t = "";
        private void SerializeObj (string filename, Scores t) {
            using (FileStream writer = new FileStream (filename, FileMode.Create)) {
                IFormatter formatter = new BinaryFormatter ();
                formatter.Serialize (writer, t);
            }
        }
        private Scores DeserializeObj (string filename) {
            try {
                using (FileStream reader = new FileStream (filename, FileMode.Open)) {
                    IFormatter formatter = new BinaryFormatter ();
                    return (Scores) formatter.Deserialize (reader);
                }
            } catch (System.IO.FileNotFoundException e) {
                SerializeObj ("PlayerRecords", scores);
                using (FileStream reader = new FileStream (filename, FileMode.Open)) {
                    IFormatter formatter = new BinaryFormatter ();
                    return (Scores) formatter.Deserialize (reader);
                }
            }
        }
        public static void newFood () {
            decimal seed = decimal.Parse (DateTime.Now.Second.ToString ());
            int s = (int) seed;
            Random ran = new Random (s);
            int a = ran.Next (1, maxH - 1);
            int b = ran.Next (1, maxW - 1);
            while (map[a, b] != 1) {
                a = ran.Next (1, maxH - 1);
                b = ran.Next (1, maxW - 1);
            }

            map[a, b] = 3;
        }
        public static Position[] food = new Position[15];
        public static int now = 0;
        public void initializeMap () {
            now = 0;
            for (int i = 0; i < maxH + 1; i++) {
                map[0, i] = 0;
                map[maxH, i] = 0;
                map[i, 0] = 0;
                map[i, maxW] = 0;
            }
            for (int i = 1; i < maxH; i++) {
                for (int ii = 1; ii < maxH; ii++)
                    map[i, ii] = 1; //1 表示区域空
            }
            map[5, 5] = 2; //2 表示贪食蛇身体
            map[6, 8] = 3; //3表示食物
        }

        Snack snack;
        bool next;
        private void Run (int mode) {
            Pause.Enabled = true;
            cot = 3;
            if (mode == 1) {        //手动操控蛇
                snack = new Snack ();
            } else {
                snack = new RobortSnack ();
                playerName.Text = "RobortSnack";
                timer.Interval = 50;
            }
            timer.Interval = interval;
            mapString.Font = new Font (mapString.Font.FontFamily.Name, 60);
            mapString.Text = "\r\n  3";
            timer.Start ();
        }

        public void Start (Status a) {
            interval = a.interval;
            maxH = a.size;
            maxW = a.size;
            playerName.Text = a.playername;
            initializeMap ();
            showString ();
            Run (a.mode);
        }
        private void Button1_Click (object sender, EventArgs e) {
            if (playerName.Text == "RobortSnack")
                playerName.Text = "Player1";
            initializeMap ();
            showString ();
            Run (1);
        }

        private void Timer1_Tick (object sender, EventArgs e) {
            if (cot > 1) {
                cot--;
                mapString.Text = "\r\n  " + cot.ToString ();
                return;
            }
            Snack.setdirc (input);
            next = snack.Walk ();
            snackLength.Text = "Length: " + snack.getLenth ();
            if (next == false) {
                timer.Stop ();
                Pause.Enabled = false;
                Score t = new Score ();
                t.setLength (snack.getlength ());
                t.setPlayerName (playerName.Text);
                if (scores.add (t))
                    mapString.Text += "\r\nYou Break The Record!";
                else
                    mapString.Text += "\r\nYou Fail!";
                SerializeObj ("PlayerRecords", scores);
            } else
                showString ();
            int tt = snack.getReach ();
            if (tt != -1)
                reach.Text = tt + " blocks\r\nwithin reach"; // + snack.getReach();
            else
                reach.Text = "";
        }

        #region 改变时间间隔

        private void SToolStripMenuItem_Click (object sender, EventArgs e) {
            interval = 1000;
        }

        private void SToolStripMenuItem1_Click (object sender, EventArgs e) {
            interval = 2000;
        }

        private void SToolStripMenuItem2_Click (object sender, EventArgs e) {
            interval = 500;
        }

        private void SToolStripMenuItem3_Click (object sender, EventArgs e) {
            interval = 300;
        }
        private void SToolStripMenuItem4_Click (object sender, EventArgs e) {
            interval = 100;
        }
        #endregion

        private void 手动ToolStripMenuItem_Click (object sender, EventArgs e) {
            initializeMap ();
            showString ();
            playerName.Text = "Player1";
            Run (1);
        }

        private void ToolStripMenuItemAuto_Click (object sender, EventArgs e) {
            initializeMap ();
            showString ();
            Run (2);
        }

        public void ToolStripMenuItemRecords_Click (object sender, EventArgs e) {
            scores = DeserializeObj ("PlayerRecords");
            Form recordsForm = new Records (scores.showName (), scores.showLength ());
            recordsForm.Text = "Records";
            recordsForm.Show ();

        }

        private void Pause_Click (object sender, EventArgs e) {
            if (timer.Enabled) {
                Pause.Text = "Cintinue";
                timer.Stop ();
                timer.Interval = interval;
            } else{
                Pause.Text = "Pause";
                timer.Start ();
            }

        }

     
        public void inputKey( KeyPressEventArgs e)
        {
            if (e.KeyChar == 's')
            {
                if (Snack.getdirc() != face.down)
                    input = face.up;
            }
            else if (e.KeyChar == 'd')
            {
                if (Snack.getdirc() != face.left)
                    input = face.right;
            }
            else if (e.KeyChar == 'a')
            {
                if (Snack.getdirc() != face.right)
                    input = face.left;
            }
            else if (e.KeyChar == 'w')
            {
                if (Snack.getdirc() != face.up)
                    input = face.down;
            }

        }
     
        private void ToolStripMenuItem2_Click (object sender, EventArgs e) {
            maxH = 11;
            maxW = 11;
            initializeMap ();
            showString ();
            Run (1);

        }

        private void ToolStripMenuItem3_Click (object sender, EventArgs e) {
            maxH = 16;
            maxW = 16;
            initializeMap ();
            showString ();
            Run (1);

        }

        private void ToolStripMenuItem4_Click (object sender, EventArgs e) {
            maxH = 21;
            maxW = 21;
            initializeMap ();
            showString ();
            Run (1);

        }

    

        private void Back_Click (object sender, EventArgs e) {
            timer.Stop ();
            this.Close ();
            main.showMain ();
            return;
        }

        

     
        private void SnackLength_Click (object sender, EventArgs e) {

        }
    }
}