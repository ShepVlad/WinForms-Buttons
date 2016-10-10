using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsButtons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox1.Focus();
            }
            else
            {
                textBox2.Focus();
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ReadOnly = false;
                textBox2.ReadOnly = true;
                textBox1.Focus();
            }
            else
            {
                textBox2.Focus();
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = false;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            textBox1.Clear();
            textBox2.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                if (textBox1.Text.IndexOf(',') != -1 ||
                    textBox1.Text.Length == 0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = ',';
                }
                return;
            }
            if (e.KeyChar == ',')
            {
                if (textBox1.Text.IndexOf(',') != -1 ||
                     textBox1.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }
            e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' )
            {
                return;
            }
            if (Char.IsControl(e.KeyChar))
            {
                return;
            }

            if (e.KeyChar == '.')
            {
                if (textBox2.Text.IndexOf(',') != -1 ||
                    textBox2.Text.Length==0)
                {
                    e.Handled = true;
                }
                else
                {
                    e.KeyChar = ',';
                }
                return;
            }
            if (e.KeyChar == ',')
            {
               if(textBox2.Text.IndexOf(',')!= -1 ||
                    textBox2.Text.Length == 0)
                {
                    e.Handled = true;
                }
                return;
            }
                e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.TextLength > 0)
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
           if(radioButton1.Checked)
            {
                textBox1.Focus();
            }
           if(radioButton2.Checked)
            {
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double F, C;
            int k = 0;
            string s;
            if(radioButton1.Checked)
            {
                F = Convert.ToDouble(textBox1.Text);
                C = (F - 32) * 5 / 9;
                textBox2.Text = String.Format("{0:F}", C);
                s =  String.Format("{1}.{2} {0:F} \r\n", C, k, "F->C ");
                textBox3.Text += s;
                k++;
            }
            else
            {
                C = Convert.ToDouble(textBox2.Text);
                F = 32 + C * 9 / 5;
                textBox1.Text = String.Format("{0:F}", F);
                s= String.Format("{1}. C->F {0:F} \r\n", F, k);
                textBox3.Text += s;
                k++;
            }
            FileStream fs = new FileStream(@"..\..\Data\Data.txt",
                FileMode.Open, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(textBox3.Text);
            sw.Close();
            fs.Close();
        }
    }
}
