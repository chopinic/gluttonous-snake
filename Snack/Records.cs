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
    public partial class Records : Form
    {
        public Records()
        {
            InitializeComponent();

        }
        public Records(int[] a)
        {
            InitializeComponent();
            string records = "";
            foreach (int i in a)
            {
                records += i;
                records += "\r\n";
            }
            label2.Text = records;
        }
        public Records(string name,string length)
        {
            InitializeComponent();
            label1.Text = name;
            label3.Text = length;


        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
