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
        static private bool isDecimal = false;
        static private bool isAnswer = false;
        static private bool isOpInLast = false;
        static private bool isNegative = false;
        static private List<bool> numberDecimal = new List<bool>();

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonEmptyMemory_Click(object sender, EventArgs e)
        {

        }

        private void makeEmptyScreen(string temp, bool check)
        {
            isOpInLast = false; //digunakan untuk multi operasi
            isAnswer = false;
            if (temp == "0" || check)
            {
                labelScreen.Text = "";
                isAnswer = false;
            }
        }

        private void buttonNum0_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "0";
        }

        private void buttonNum1_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "1";
        }

        private void buttonNum2_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "2";
        }

        private void buttonNum3_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "3";
        }

        private void buttonNum4_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "4";
        }

        private void buttonNum5_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "5";
        }

        private void buttonNum6_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "6";
        }

        private void buttonNum7_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "7";
        }

        private void buttonNum8_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "8";
        }

        private void buttonNum9_Click(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "9";
        }

        private void buttonDesimal_Click(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                isDecimal = true;
                labelScreen.Text += ",";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string temp = labelScreen.Text.Substring(labelScreen.Text.Length - 1);
            if (isAnswer)
            {
                isAnswer = false;
            }
            else if (temp == ",")
            {
                isDecimal = false;
            }
            else if ((temp == "+" || temp == "*" || temp == "÷" || temp == "-") && !isNegative)
            {
                isOpInLast = false;
                isDecimal = numberDecimal[numberDecimal.Count-1];
                numberDecimal.RemoveAt(numberDecimal.Count - 1);
            }
            labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
            if (labelScreen.Text.Length == 0)
            {
                labelScreen.Text = "0";
            }
        }

        private void buttonAllClear_Click(object sender, EventArgs e)
        {
            labelScreen.Text = "0";
            isDecimal = false;
            numberDecimal.Clear();
            isAnswer = false;
            isOpInLast = false;
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            if (!isNegative)
            {
                if (isOpInLast)
                {
                    labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
                }
                labelScreen.Text += "+";
                isOpInLast = true;
                numberDecimal.Add(isDecimal);
            }
            isDecimal = false;
            isAnswer = false;
        }

        private void buttonSubtraction_Click(object sender, EventArgs e)
        {
            string temp = labelScreen.Text.Substring(labelScreen.Text.Length - 1);
            if (temp == "*" || temp == "÷")
            {
                isNegative = true;
            }
            else if (temp == "+" || temp == "-")
            {
                labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
                numberDecimal.Add(isDecimal);
            }
            labelScreen.Text += "-";
            isOpInLast = true;
            isDecimal = false;
            isAnswer = false;
        }

        private void buttonMultiplication_Click(object sender, EventArgs e)
        {
            if (!isNegative)
            {
                if (isOpInLast)
                {
                    labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
                }
                labelScreen.Text += "*";
                isOpInLast = true;
                numberDecimal.Add(isDecimal);
            }
            isDecimal = false;
            isAnswer = false;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            if (!isNegative)
            {
                if (isOpInLast)
                {
                    labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
                }
                labelScreen.Text += "÷";
                isOpInLast = true;
                numberDecimal.Add(isDecimal);
            }
            isDecimal = false;
            isAnswer = false;
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            labelScreen.Text += "√";
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

        }
    }
}
