using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            textBox3.Enabled = false;
            radioButton5.Enabled = false;
            textBox1.Focus();
            

            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Enabled = true;
            textBox1.Focus();




        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton5.Checked)
            {
                radioButton5.Checked = false;
                radioButton5.Enabled = false;
                radioButton8.Checked = true;

               
            }
            else
            {
                radioButton5.Enabled = true;
                radioButton5.Checked = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked==true)
            {
                radioButton8.Checked = false;
                radioButton8.Enabled= false;
                radioButton5.Checked = true;
            }
            else
            {
                radioButton8.Enabled = true;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked == true)
            {
                double cursDollaraKup= 25.751;
                double cursDollaraPro = 26.062;
                radioButton7.Checked = false;
                radioButton7.Enabled = false;
                radioButton5.Checked = true;

                if (textBox1.Enabled == true)
                {
                    if (radioButton9.Checked == true)
                    {
                        if (radioButton5.Checked == true)
                        {
                            double money;
                            double Exit;
                            string s = textBox1.Text;
                            money = Convert.ToDouble(s);
                            Exit = money * cursDollaraKup;

                            textBox3.Text += Exit;

                        }
                    }
                }
            }
            else
            {
                radioButton7.Enabled = true;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                radioButton6.Checked = false;
                radioButton6.Enabled = false;
                radioButton5.Checked = true;
            }
            else
            {
                radioButton6.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text.Length>0)
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
            
        }
    }
}
