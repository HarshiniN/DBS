using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1q1
{
    public partial class Form1 : Form
    {
        String input = String.Empty;
        String op1 = String.Empty;
        String op2 = String.Empty;
        char Operator;
        double res = 0.0;
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Text = String.Empty;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            
            input = input + "0";
            this.textBox1.Text += input;
        }

        private void buttondot_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + ".";
            this.textBox1.Text += input;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            input = input + "1";
            this.textBox1.Text += input;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            input = input + "2";
            this.textBox1.Text += input;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + "3";
            this.textBox1.Text += input;
        }

        private void button4_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + "4";
            this.textBox1.Text += input;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + "5";
            this.textBox1.Text += input;
        }

        private void button6_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + "6";
            this.textBox1.Text += input;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           this.textBox1.Text = String.Empty;
            input = input + "7";
            this.textBox1.Text += input;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            input = input + "8";
            this.textBox1.Text += input;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            input = input + "9";
            this.textBox1.Text += input;
        }

        private void buttonequals_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = String.Empty;
            op2 = input;
           
            double num1, num2;
            double.TryParse(op1, out num1);
            double.TryParse(op2, out num2);
            if (Operator == '+')
            {
                res = num1 + num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '-')
            {
                res = num1 - num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '*')
            {
                res = num1 * num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == '/')
            {
                if (num2 != 0)
                {
                    res = num1 / num2;
                    this.textBox1.Text = res.ToString();

                }
                else
                    this.textBox1.Text = "Inifinity";
            }
            else if(Operator=='%')
            {
                res = num1 % num2;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 's')
            {
                res = num1 * num1;
                this.textBox1.Text = res.ToString();

            }
            else if (Operator == 'c')
            {
                res = num1 * num1 * num1;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'p')
            {res=1.0;
                for (double i = 0; i < num2; i++)
                {
                    res = res * num1;
                }
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'r')
            {
                res = System.Math.Sqrt(num2);
                this.textBox1.Text = res.ToString();

            }
            else if (Operator == 'f')
            {
                res = 1.0;
                for (double i = num1; i >= 1; i++)
                    res = res * i;
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'S')
            {
                res = Math.Sin(num2);
                this.textBox1.Text = res.ToString();
            }
            else if(Operator=='L')
            {
                res = Math.Log(num2);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'l')
            {
                res = Math.Log10(num2);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'C')
            {
                res = Math.Cos(num2);
                this.textBox1.Text = res.ToString();
            }
            else if (Operator == 'T')
            {
                res = Math.Tan(num2);
                this.textBox1.Text = res.ToString();
            }

            input = string.Empty;
        }

        private void buttondivides_Click(object sender, EventArgs e)
        {
        op1 = input;
            Operator = '/';
            input = String.Empty;
            this.textBox1.Text ="/";
        }

        private void buttontimes_Click(object sender, EventArgs e)
        {
        op1 = input;
            Operator = '*';
            input = String.Empty;
            this.textBox1.Text ="*";
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
        op1 = input;
            Operator = '-';
            input = String.Empty;
            this.textBox1.Text ="-";
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
        op1 = input;
            Operator = '+';
            input = String.Empty;
            this.textBox1.Text ="+";
        }

        private void buttonmod_Click(object sender, EventArgs e)
        {
        op1 = input;
            Operator = '%';
            input = String.Empty;
            this.textBox1.Text = "%";
        }

        private void buttonsqrt_Click(object sender, EventArgs e)
        {
            Operator='r';
        this.textBox1.Text="sqrt";
        }

        private void buttonsquare_Click(object sender, EventArgs e)
        {op1=input;
        Operator='s';
        this.textBox1.Text="^2";
            input=String.Empty;
        }

        private void buttoncube_Click(object sender, EventArgs e)
        {
        op1=input;
        Operator='c';
        this.textBox1.Text="^3";
            input=String.Empty;
        }

        private void buttonpower_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'p';
            this.textBox1.Text = "^";
            input = String.Empty;
        }

        private void buttonpi_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
        }

        private void buttonfactorial_Click(object sender, EventArgs e)
        {
            op1 = input;
            Operator = 'f';
            this.textBox1.Text += "!";
            input = String.Empty;
        }

        private void buttonsin_Click(object sender, EventArgs e)
        {
            Operator = 'S';
            this.textBox1.Text += "Sin";
        }

        private void buttonlnx_Click(object sender, EventArgs e)
        {
            Operator = 'L';
            this.textBox1.Text += "Ln";
        }

        private void buttonlog_Click(object sender, EventArgs e)
        {
            Operator = 'l';
            this.textBox1.Text += "Log";

        }

        private void buttoncos_Click(object sender, EventArgs e)
        {
            Operator = 'C';
            this.textBox1.Text += "Cos";
        }

        private void buttontan_Click(object sender, EventArgs e)
        {
            Operator = 'T';
            this.textBox1.Text += "Tan";
        }
    }
}

        
        

        