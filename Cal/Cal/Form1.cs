using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cal
{
    public partial class Form1 : Form
    {
        private static double num;
        private static double num2;
        private static string ope = "";
        private static string ope2 = "";
        private static string ope3 = "";
        private static bool flag = false;
        private static bool decimal_flag = false;
        private static double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(flag)
            {
                ope3 += button5.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button5.Text;
            textBox1.Text = ope;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button1.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button1.Text;
            textBox1.Text = ope;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button2.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button2.Text;
            textBox1.Text = ope;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button3.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button3.Text;
            textBox1.Text = ope;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button4.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button4.Text;
            textBox1.Text = ope;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button6.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button6.Text;
            textBox1.Text = ope;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button7.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button7.Text;
            textBox1.Text = ope;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button8.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button8.Text;
            textBox1.Text = ope;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button9.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button9.Text;
            textBox1.Text = ope;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                ope3 += button15.Text;
                textBox1.Text = ope3;
                return;
            }
            ope += button15.Text;
            textBox1.Text = ope;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(ope))
            {
                return;
            }

            if(decimal_flag)
            {
                return;
            }

            if (flag)
            {
                if (string.IsNullOrEmpty(ope3))
                {
                    return;
                }
                if (decimal_flag)
                {
                    return;
                }
                ope3 += button5.Text;
                textBox1.Text = ope3;
                decimal_flag = true;
                return;
            }

            ope += button14.Text;
            textBox1.Text = ope;
            decimal_flag = true;
        }

        private void button13_Click(object sender, EventArgs e) //+
        {
            ope2 = "+";
            textBox1.Text = "";
            decimal_flag = false;
            flag = true;
        }

        private void button12_Click(object sender, EventArgs e) //-
        {
            ope2 = "-";
            textBox1.Text = "";
            decimal_flag = false;
            flag = true;
        }

        private void button11_Click(object sender, EventArgs e) //*
        {
            ope2 = "*";
            textBox1.Text = "";
            decimal_flag = false;
            flag = true;
        }

        private void button10_Click(object sender, EventArgs e) // /
        {
            ope2 = "/";
            textBox1.Text = "";
            decimal_flag = false;
            flag = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string final_string;

            num = Convert.ToDouble(ope);
            num2 = Convert.ToDouble(ope3);

            switch(ope2)
            {
                case "+":
                    result = num + num2;
                    break;
                case "-":
                    result = num - num2;
                    break;
                case "*":
                    result = num * num2;
                    break;
                case "/":
                    result = num / num2;
                    break;
            }

            final_string = ope + " " + ope2 + " " + ope3 + " = " + Convert.ToString(result);
            textBox1.Text = final_string;
            decimal_flag = false;
            flag = false;
            ope = "";
            ope2 = "";
            ope3 = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
