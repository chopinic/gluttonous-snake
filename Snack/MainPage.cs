using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainPage : Form
    {
        private GamePage main;
        private startPage startPage1;
        public MainPage()
        {
            InitializeComponent();
            main = new GamePage(this);
            main.TopLevel = false;
            main.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(main);
            startPage1 = new startPage(this);
            startPage1.TopLevel = false;
            startPage1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(startPage1);
            panel1.Visible = true;
            startPage1.Show();
        }
        public void showRecord()
        {
            main.ToolStripMenuItemRecords_Click(new object(), new EventArgs());
        }
        public void showMain()
        {
            startPage1 = new startPage(this);
            startPage1.TopLevel = false;
            startPage1.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(startPage1);
            panel1.Visible = true;
            startPage1.Show();
        }
        public void Start(Status status)
        {
            main = new GamePage(this);
            main.TopLevel = false;
            main.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(main);
            main.Show();
            main.Start(status);
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Main_KeyPress(object sender, KeyPressEventArgs e)
        {
            main.Form1_KeyPress(sender, e);
        }
    }
}
