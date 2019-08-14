using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            string output;
            output = this.textBox1.Text + "!!!";
            this.textBox1.Text = output;
            
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "ppp")
                tb.BackColor = Color.White;
            else
                tb.BackColor = Color.Red;
            validateOK();
        }

        private void TextBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
                tb.BackColor = Color.White;
            validateOK();
        }
        public static bool IsChineseCh(string input)   //正则表达式 汉字规则
        {
            Regex regex = new Regex("^[\u4e00-\u9fa5]+$");
            return regex.IsMatch(input);
        }
        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //此为只能输入汉字
            if ((e.KeyChar<48||e.KeyChar>57)&&e.KeyChar!=8)
            {
                textBox1.BackColor = Color.Red;
                e.Handled = true;

                //合法
            }
            else
            {
                textBox1.BackColor = Color.White;

            }
            //此为退格键可以输入
            
        }
        private void validateOK()
        {
            this.button1.Enabled = (textBox1.BackColor == Color.White&& textBox2.BackColor != Color.Red) ;

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
