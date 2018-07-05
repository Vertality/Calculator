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
    public partial class Form2 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;


        public Form2()
        {
            InitializeComponent();
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

   

        private void One_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "1";
            this.txt1.Text += input;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "2";
            this.txt1.Text += input;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "3";
            this.txt1.Text += input;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "4";
            this.txt1.Text += input;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "5";
            this.txt1.Text += input;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "6";
            this.txt1.Text += input;
        }

        private void Seven_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "7";
            this.txt1.Text += input;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "8";
            this.txt1.Text += input;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "9";
            this.txt1.Text += input;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += "0";
            this.txt1.Text += input;
        }

        private void Decimal_Click(object sender, EventArgs e)
        {
            this.txt1.Text = "";
            input += ".";
            this.txt1.Text += input;
        }

        private void Times_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double Num1, Num2;
            double.TryParse(operand1, out Num1);
            double.TryParse(operand2, out Num2);

            if (operation == '-')
            {
                result = Num1 - Num2;
            }
            else if (operation == '+')
            {
                result = Num1 + Num2;
            }
            else if (operation == '*')
            {
                result = Num1 * Num2;
            }
            else if (operation == '/')
            {
                if (Num2 != 0)
                {
                    result = Num1 / Num2;
                }
                else
                {
                    txt1.Text  = "DIV/ZERO";
                    return;
                }

            }
            input = result.ToString();
            txt1.Text = result.ToString();
        }


        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
