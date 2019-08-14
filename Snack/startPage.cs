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
    public partial class startPage : Form
    {

        Status status;
        private mainForm form1 = null;
        public startPage(mainForm form)
        {
            InitializeComponent();
            panel1.Visible = false;
            form1 = form;
            status = new Status(Playername.Text, 1000, 1, 15);
        }
        public void setSize(int k)
        {
            status.size = k;
            panel1.Visible = false;
        }
        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            status.mode = 1;
            status.playername = Playername.Text;
            this.Close();
            form1.Start(status);
        }

        private void AutoStart_Click(object sender, EventArgs e)
        {
            status.mode = 2;
            status.playername = "RobortSnack";
            status.interval = 50;
            this.Close();
            form1.Start(status);
        }

        private void Size_Click(object sender, EventArgs e)
        {
            ChooseSize size = new ChooseSize(this);
            size.TopLevel = false;
            size.FormBorderStyle = FormBorderStyle.None;
            panel1.Controls.Add(size);
            panel1.Visible = true;
            size.Show();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            form1.ToolStripMenuItemRecords_Click(new object(),new EventArgs());
        }
    }
}
