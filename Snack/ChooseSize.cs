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
    public partial class ChooseSize : Form
    {
        int size = 0;
        startPage s = null;
        public ChooseSize(startPage start)
        {
            InitializeComponent();
            s = start;
        }

        private void Size1_Click(object sender, EventArgs e)
        {
            size = 10;
            this.Close();
            s.setSize(size);
        }

        private void Size2_Click(object sender, EventArgs e)
        {
            size = 15;
            this.Close();
            s.setSize(size);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            size = 20;
            this.Close();
            s.setSize(size);
        }
    }
}
