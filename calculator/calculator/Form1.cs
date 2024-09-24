

using System.Diagnostics.Eventing.Reader;

namespace calculator
{
    


    public partial class Form1 : Form
    {
        enum Operators
        {
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }
        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;

        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorChangeFlag == true)
            {
                display.Text = "";
                operatorChangeFlag = false;
            }
            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void buttonFloat_Click(object sender, EventArgs e)
        {
            string strNumber = display.Text += ".";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            
            if (currentOperator == 0)
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Add;
            }
            else {
                secondOperand = Int32.Parse(display.Text);
                firstOperand +=secondOperand;
                secondOperand = 0;
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Add;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (currentOperator == 0)
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Subtract;
            }
            else
            {
                secondOperand = Int32.Parse(display.Text);
                firstOperand -= secondOperand;
                secondOperand = 0;
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Subtract;
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            

            if (currentOperator == 0)
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Multiply;
            }
            else
            {
                secondOperand = Int32.Parse(display.Text);
                firstOperand *= secondOperand;
                secondOperand = 0;
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Multiply;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            firstOperand = Int32.Parse(display.Text);
            display.Text = "";
            operatorChangeFlag = true;
            currentOperator = Operators.Divide;

            if (currentOperator == 0)
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Add;
            }
            else
            {
                secondOperand = Int32.Parse(display.Text);
                firstOperand += secondOperand;
                secondOperand = 0;
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Add;
            }
        }

        private void buttonAc_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            operatorChangeFlag = false;
            currentOperator = Operators.None;
            firstOperand = 0;
            secondOperand = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                secondOperand = 0;
                display.Text = firstOperand.ToString();
                currentOperator = Operators.None;
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                secondOperand = 0;
                display.Text = firstOperand.ToString();
                currentOperator = Operators.None;
            } else if(currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
                currentOperator = Operators.None;
            }
            else if(currentOperator == Operators.Divide)
            {
                if (secondOperand==0) {
                    display.Text = "0으로 나눌수 없습니다."; 
                }
                else { 
                int sum = firstOperand / secondOperand;
                display.Text = sum.ToString();
                    currentOperator = Operators.None;
                }
            }
        }
    }
}