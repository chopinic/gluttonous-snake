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
    public partial class Main : Form
    {
        private GamePage main;
        private startPage startPage1;
        //public Status status;
        public Main()
        {
            InitializeComponent();
            main = new GamePage(this);
            startPage1 = new startPage(this);
            startPage1.TopLevel = false;
            main.TopLevel = false;
            startPage1.FormBorderStyle = FormBorderStyle.None;
            main.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(startPage1);
            panel1.Controls.Add(main);
            panel1.Visible = true;
            startPage1.Show();
        }
        public void showRecord()
        {
            main.ToolStripMenuItemRecords_Click(new object(), new EventArgs());
        }
        public void showMain()
        {
            panel1.Visible = true;
            startPage1.Show();
        }
        public void Start(Status status)
        {
            main.Show();
            main.Start(status);
        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
