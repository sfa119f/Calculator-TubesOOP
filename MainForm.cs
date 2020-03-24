using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tubes_1;

namespace Calculator
{
    public partial class MainForm : Form
    {
        static private char unaryOp = ' ';
        static private char op = ' ';
        static private bool isError = false;
        static private bool isDecimal = false;
        static private bool isAnswer = false;
        static private bool isOpInLast = false;
        static private bool isNegative = false;
        static private bool isRoot = false;
        static private List<bool> numberDecimal = new List<bool>();
        static private string lastStrNumber = "";
        static private bool hasAnswer = false;
        static private double nilaiAnswer;
        static private bool isOneOp = false;
        private Queue<double> queueMC = new Queue<double>(5);
        static private bool isMcEmpty = true;

        public MainForm()
        {
            Thread t = new Thread(new ThreadStart(startingForm));
            t.Start();
            Thread.Sleep(1500);
            InitializeComponent();
            t.Abort();
        }

        public void startingForm()
        {
            Application.Run(new StartForm());
        }

        public async void waitingTime()
        {
            await Task.Delay(5000);
        }

        private void buttonEmptyMemory_onClick(object sender, EventArgs e)
        {
            queueMC.Clear();
            isMcEmpty = true;
            clearData();
            isAnswer = false;
            labelScreen.Text = "0";
        }

        private void makeEmptyScreen(string temp, bool check)
        {
            isOpInLast = false; //digunakan untuk multi operasi
            isAnswer = false;
            isNegative = false;
            if (temp == "0" || check || isError)
            {
                labelScreen.Text = "";
                isAnswer = false;
                isError = false;
            }
        }

        private void buttonNum0_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "0";
            lastStrNumber += "0";
            isOpInLast = false;
        }

        private void buttonNum1_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "1";
            lastStrNumber += "1";
            isOpInLast = false;
        }

        private void buttonNum2_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "2";
            lastStrNumber += "2";
            isOpInLast = false;
        }

        private void buttonNum3_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "3";
            lastStrNumber += "3";
            isOpInLast = false;
        }

        private void buttonNum4_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "4";
            lastStrNumber += "4";
            isOpInLast = false;
        }

        private void buttonNum5_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "5";
            lastStrNumber += "5";
            isOpInLast = false;
        }

        private void buttonNum6_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "6";
            lastStrNumber += "6";
            isOpInLast = false;
        }

        private void buttonNum7_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "7";
            lastStrNumber += "7";
            isOpInLast = false;
        }

        private void buttonNum8_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "8";
            lastStrNumber += "8";
            isOpInLast = false;
        }

        private void buttonNum9_onClick(object sender, EventArgs e)
        {
            makeEmptyScreen(labelScreen.Text, isAnswer);
            labelScreen.Text += "9";
            lastStrNumber += "9";
            isOpInLast = false;
        }

        private void buttonDesimal_onClick(object sender, EventArgs e)
        {
            if (!isDecimal)
            {
                isDecimal = true;
                labelScreen.Text += ".";
                lastStrNumber += ".";
            }
        }

        private void buttonNegative_onClick(object sender, EventArgs e)
        {
            if(lastStrNumber.Length > 0)
            {
                labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - lastStrNumber.Length);
            }
            if (labelScreen.Text == "0")
            {
                labelScreen.Text = "";
            }
            if (labelScreen.Text == "")
            {
                labelScreen.Text += "-";
            }
            else if (labelScreen.Text.Substring(labelScreen.Text.Length - 1) == " ") //last substring " " menandakan bahwa last substring adl " (op) "
            {
                labelScreen.Text += "-";
            }
            else if (labelScreen.Text.Substring(labelScreen.Text.Length - 1) == "-")
            {
                labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
            }
            if(lastStrNumber == "")
            {
                isNegative = !isNegative;
            }
            labelScreen.Text += lastStrNumber;
            if(labelScreen.Text == "")
            {
                labelScreen.Text = "0";
            }
        }

        private void buttonDelete_onClick(object sender, EventArgs e)
        {
            string temp = labelScreen.Text.Substring(labelScreen.Text.Length - 1);
            if (isAnswer)
            {
                isAnswer = false;
            }
            if (isRoot)
            {
                isRoot = false;
            }
            else if (temp == ".")
            {
                isDecimal = false;
            }
            else if (temp == "-")
            {
                isOpInLast = true;
                isNegative = false;
            }
            else if ((temp == " ") && !isNegative && labelScreen.Text.Length != 1) //temp punya substring " (op) "
            {
                isOpInLast = false;
                isOneOp = false;
                isDecimal = numberDecimal[numberDecimal.Count - 1];
                numberDecimal.RemoveAt(numberDecimal.Count - 1);
                labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 2);
                for (int i = 0; i < labelScreen.Text.Length; i++)
                {
                    if (labelScreen.Text[i] != '-')
                    {
                        lastStrNumber += labelScreen.Text[i];
                    }
                }
            }
            else
            {
                lastStrNumber.Remove(lastStrNumber.Length - 1);
                if(labelScreen.Text.Length > 1)
                {
                    if(labelScreen.Text.Substring(labelScreen.Text.Length - 2)[0] == '-')
                    {
                        isNegative = true;
                    }
                }
            }
            labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 1);
            if (labelScreen.Text.Length == 0)
            {
                labelScreen.Text = "0";
                if (isNegative)
                {
                    isNegative = false;
                }
            }
        }

        private void clearData()
        {
            isDecimal = false;
            isNegative = false;
            numberDecimal.Clear();
            lastStrNumber = "";
            isOpInLast = false;
            isRoot = false;
            isOneOp = false;
        }

        private void buttonAllClear_onClick(object sender, EventArgs e)
        {
            clearData();
            isAnswer = false;
            labelScreen.Text = "0";
        }

        private void inputOperator(string op)
        {
            if (!isNegative && !isRoot && (!isOneOp || isOpInLast))
            {
                if (isOpInLast)
                {
                    labelScreen.Text = labelScreen.Text.Remove(labelScreen.Text.Length - 3);
                    numberDecimal.RemoveAt(numberDecimal.Count - 1);
                }
                labelScreen.Text += op;
                isOpInLast = true;
                isOneOp = true;
                isDecimal = false;
                isAnswer = false;
                numberDecimal.Add(isDecimal);
                lastStrNumber = "";
            }
        }

        private void buttonSum_onClick(object sender, EventArgs e)
        {
            inputOperator(" + ");
        }

        private void buttonSubtraction_onClick(object sender, EventArgs e)
        {
            if (labelScreen.Text.Substring(labelScreen.Text.Length - 1) == " ") //last substring " " menandakan bahwa last substring adl " (op) "
            {
                labelScreen.Text += "-";
                isNegative = true;
            }
            else
            {
                inputOperator(" - ");
            }
        }

        private void buttonMultiplication_onClick(object sender, EventArgs e)
        {
            inputOperator(" * "); 
        }

        private void buttonDivision_onClick(object sender, EventArgs e)
        {
            inputOperator(" ÷ ");
        }

        private void buttonRoot_onClick(object sender, EventArgs e)
        {
            if (labelScreen.Text == "0")
            {
                makeEmptyScreen(labelScreen.Text, isAnswer);
                labelScreen.Text += "√";
                isRoot = true;
            }
        }

        private double CalculateUnary(TerminalExpression a)
        {
            RootExpression<double> hasil = new RootExpression<double>(a);
            return hasil.solve();
        }
        private double CalculateBinary(TerminalExpression a, TerminalExpression b)
        {
            // double hasil = 0;
            if (op == '+')
            {
                AddExpression hasil = new AddExpression(a, b);
                //hasil = a + b;
                return hasil.solve();
            }
            else if (op == '-')
            {
                SubstractExpression hasil = new SubstractExpression(a, b);
                //hasil = a - b;
                return hasil.solve();
            }
            else if (op == '*')
            {
                MultiplyExpression hasil = new MultiplyExpression(a, b);
                //hasil = a * b;
                return hasil.solve();
            }
            else if (op == '÷')
            {
                DivisionExpression hasil = new DivisionExpression(a, b);
                //hasil = a / b;
                return hasil.solve();
            }

            return 0;
        }
        private void buttonResult_onClick(object sender, EventArgs e)
        {
            int i = 0;
            string ekspresi = labelScreen.Text;
            double ans;
            TerminalExpression ansNow;
            TerminalExpression operandWithClass;

            ansNow = new TerminalExpression();
            //double ansNow = 0;
            StringBuilder ekspresi1 = new StringBuilder();

            
            if (ekspresi.Length == 0)
            {
                labelScreen.Text = "Error: Nothing inside";
                isError = true;
            }
            else
            {
                double operand;
                try
                {
                    while (i < ekspresi.Length)
                    {
                        if (ekspresi[i] == '-' && ekspresi[i + 1] != ' ')
                        {
                            unaryOp = '-';
                        }
                        else if (ekspresi[i] == '+' || ekspresi[i] == '-' || ekspresi[i] == '*' || ekspresi[i] == '÷')
                        {
                            operand = double.Parse(ekspresi1.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                            TerminalExpression transition = new TerminalExpression(operand);
                            if (unaryOp == '-')
                            {
                                NegativeExpression<double> negative = new NegativeExpression<double>(transition);
                                ansNow.setX(negative.solve());
                                unaryOp = ' ';
                            }
                            else
                            {
                                ansNow.setX(operand);
                            }

                            op = ekspresi[i];
                            ekspresi1.Clear();
                        }
                        else if (ekspresi[i] == '√')
                        {
                            unaryOp = '√';
                        }
                        else
                        {
                            ekspresi1.Append(ekspresi[i]);
                        }
                        i++;
                    }
                    operand = double.Parse(ekspresi1.ToString(), System.Globalization.CultureInfo.InvariantCulture);
                    if (unaryOp == '-')
                    {
                        operand = operand * -1;
                        unaryOp = ' ';
                    }
                    operandWithClass = new TerminalExpression(operand);
                    if (unaryOp == '√')
                    {
                        ans = CalculateUnary(operandWithClass);
                        //operand = Math.Sqrt(operand);
                        unaryOp = ' ';
                    }
                    else if (op == ' ')
                    {
                        ans = operand;
                    }
                    else
                    {
                        ans = CalculateBinary(ansNow, operandWithClass);
                    }
                    ans = Math.Round(ans, 5);
                    labelScreen.Text = ans.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    lastStrNumber = ans.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    isDecimal = false;
                    isNegative = false;
                    numberDecimal.Clear();
                    isOpInLast = false;
                    isRoot = false;
                    isOneOp = false;

                    nilaiAnswer = double.Parse(ans.ToString(System.Globalization.CultureInfo.InvariantCulture), System.Globalization.CultureInfo.InvariantCulture);
                    isAnswer = true;
                    hasAnswer = true;

                    bool hasKoma = false;
                    int temp = 0;
                    while ((temp < labelScreen.Text.Length) && (!hasKoma))
                    {
                        if (labelScreen.Text[temp] == '.')
                        {
                            hasKoma = true;
                        }
                        else
                        {
                            temp++;
                        }
                    }
                    if (hasKoma)
                    {
                        isDecimal = true;
                    }

                    op = ' ';
                }
                catch (Error a)
                {
                    clearData();
                    isError = true;

                    op = ' ';
                    labelScreen.Text = a.printMessage();
                }
            }
            isDecimal = true;

        }
        private void buttonAnswer_onClick(object sender, EventArgs e)
        {
            if (!hasAnswer)
            {
                labelScreen.Text = "Error: no Answer";
                isError = true;
            }
            else
            {
                if (isOpInLast || string.Compare(labelScreen.Text, "0")==0)
                {
                    clearData();
                    if(string.Compare(labelScreen.Text, "0")==0)
                    {
                        labelScreen.Text = "";
                    }
                    labelScreen.Text += nilaiAnswer.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    isOpInLast = false;
                    for (int i = 0; i < labelScreen.Text.Length; i++)
                    {
                        if (labelScreen.Text[i] != '-')
                        {
                            lastStrNumber += labelScreen.Text[i];
                        }
                    }
                    bool hasKoma = false;
                    int temp = 0;
                    while ((temp < labelScreen.Text.Length) && (!hasKoma))
                    {
                        if (labelScreen.Text[temp] == '.')
                        {
                            hasKoma = true;
                        }
                        else
                        {
                            temp++;
                        }
                    }
                    if (hasKoma)
                    {
                        isDecimal = true;
                    }
                }
                
            }
        }

        private void buttonSaveValue_onClick(object sender, EventArgs e)
        {
            bool isNotNumber = false;
            int i = 0;
            string temp = labelScreen.Text;
            while ((!isNotNumber) && (i < temp.Length))
            {
                if ( (temp[i] == '+') || (temp[i] == '*') || (temp[i] == '÷') || (temp[i] == '√') )
                {
                    labelScreen.Text = "Error: Invalid Input";
                    isNotNumber = true;
                    isError = true;
                    isAnswer = true;
                    isOneOp = false;
                    isOpInLast = false;
                    isDecimal = false;
                }
                else if ( (temp[i] == '-') && (i != 0) || temp[i] == 'E' || temp[i] == 'r')
                {
                    labelScreen.Text = "Error: Invalid Input";
                    isNotNumber = true;
                    isError = true;
                    isAnswer = true;
                    isOneOp = false;
                    isOpInLast = false;
                    isDecimal = false;
                }
                else
                {
                    i++;
                }
            }
            if (!isNotNumber)
            {
                queueMC.Enqueue(double.Parse(temp.ToString(System.Globalization.CultureInfo.InvariantCulture), System.Globalization.CultureInfo.InvariantCulture));
                isDecimal = false;
                if (isMcEmpty)
                {
                    isMcEmpty = false;
                }
            }
            
        }

        private void buttonGetValue_onClick(object sender, EventArgs e)
        {
           if (isMcEmpty)
            {
                labelScreen.Text = "Err: Mem Empty";
                isError = true;
            }
           else
            {
                double temp = queueMC.Dequeue();
                int i = 0;
                bool hasKoma = false;
                while ((i < (Convert.ToString(temp)).Length) && (!hasKoma))
                {
                    if (Convert.ToString(temp)[i].Equals(','))
                    {
                        hasKoma = true;
                    }
                    else
                    {
                        i++;
                    }
                }

                if (isOneOp)
                {
                    if ((hasKoma) && (isDecimal))
                    {
                        queueMC.Enqueue(temp);
                    }
                    else
                    {
                        labelScreen.Text += temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                        lastStrNumber = temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    }
                }

                else if ( (!isOneOp) && ( (!isAnswer) && (labelScreen.Text != "0" ) ) )  
                {
                    inputOperator(" * ");
                    labelScreen.Text += temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    lastStrNumber += temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                }
                else if ( (isAnswer) || (labelScreen.Text == "0") )
                {
                    labelScreen.Text = temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    lastStrNumber = temp.ToString(System.Globalization.CultureInfo.InvariantCulture);
                }
                

                if (hasKoma)
                {
                    isDecimal = true;
                }
                if (queueMC.Count == 0)
                {
                    isMcEmpty = true;
                }
            }
        }
    }
}


