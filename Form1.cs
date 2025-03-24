using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float num1;
        float num2;
        char opr;
        float result = 0;
        bool isFirst = true;
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "0";
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "6";
        }
        private void one_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "1";
        }
        private void Nine_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "9";
        }
        private void Three_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "3";
        }
        private void Two_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "2";
        }
        private void Four_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "4";
        }
        private void Five_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "5";
        }
        private void Seven_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "7";
        }
        private void Eight_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += "8";
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text = "";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "") return;

            opr = '+';
            num1 = float.Parse(Screen.Text);
            Screen.Text = "";
        }
        private void Sum_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "") return;

            opr = '-';
            num1 = float.Parse(Screen.Text);
            Screen.Text = "";
        }
        private void Multiply_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "") return;

            opr = '*';
            num1 = float.Parse(Screen.Text);
            Screen.Text = "";
        }
        private void Divide_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "") return;

            opr = '/';
            num1 = float.Parse(Screen.Text);
            Screen.Text = "";
        }
        private void Percentage_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "") return;
            opr = '%';
            num1 = float.Parse(Screen.Text);
            Screen.Text = "";

        }
        private void Equal_Click(object sender, EventArgs e)
        {
            num2 = float.Parse(Screen.Text);
          
            switch (opr)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Screen.Text = "Error";
                    break;
                case '%':
                  result = (num1 * num2) / 100;
                    break;
            }

            Screen.Text = result.ToString();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (isFirst)
            {
                Screen.Text = "";
                isFirst = false;
            }
            Screen.Text += ".";
        }
    }
}
