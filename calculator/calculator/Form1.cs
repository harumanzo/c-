

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
            
            if (currentOperator == 0)/* ��ȣ�� �������� �����̰ų� =���� ��� ���������� ���¿��� ����*/
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Add;
            }
            else
            {/* =�� �����ʰ� ���Ӱ���Ҷ� �Ʒ��� ���� ������*/
                if (currentOperator == Operators.Add)
                {/* ���� ��ȣ�� +������� */
                    secondOperand = Int32.Parse(display.Text);//��ȸ���� ������ ���ڸ� ����
                    firstOperand += secondOperand; //�������ڿ� ������ְ�
                    secondOperand = 0;//������ �ʱ�ȭ
                    display.Text = "";
                    currentOperator = Operators.Add;/* �������� Ŭ���ߴ� +��ư���� currentOperator�� �������ش� =�� ������츦 �����ؾ��ϱ⶧��*/
                }
                else if(currentOperator == Operators.Subtract)
                {/* ���� ��ȣ�� -������� */
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand -= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Add;
                }
                else if(currentOperator == Operators.Multiply)
                {/* ���� ��ȣ�� *������� */
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand *= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Add;
                }else if(currentOperator == Operators.Divide)
                {/* ���� ��ȣ�� /������� */
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand /= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Add;
                }

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
                if (currentOperator == Operators.Add)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand += secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Subtract;
                }
                else if (currentOperator == Operators.Subtract)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand -= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Subtract;
                }
                else if (currentOperator == Operators.Multiply)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand *= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Subtract;
                }
                else if (currentOperator == Operators.Divide)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand /= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Subtract;
                }
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
                if (currentOperator == Operators.Add)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand += secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Multiply;
                }
                else if (currentOperator == Operators.Subtract)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand -= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Multiply;
                }
                else if (currentOperator == Operators.Multiply)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand *= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Multiply;
                }
                else if (currentOperator == Operators.Divide)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand /= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Multiply;
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            

            if (currentOperator == 0)
            {
                firstOperand = Int32.Parse(display.Text);
                display.Text = "";
                operatorChangeFlag = true;
                currentOperator = Operators.Divide;
            }
            else
            {
                if (currentOperator == Operators.Add)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand += secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Divide;
                }
                else if (currentOperator == Operators.Subtract)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand -= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Divide;
                }
                else if (currentOperator == Operators.Multiply)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand *= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Divide;
                }
                else if (currentOperator == Operators.Divide)
                {
                    secondOperand = Int32.Parse(display.Text);
                    firstOperand /= secondOperand;
                    secondOperand = 0;
                    display.Text = "";
                    currentOperator = Operators.Divide;
                }
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
                    display.Text = "0���� ������ �����ϴ�."; 
                }
                else { 
                firstOperand /= secondOperand;
                display.Text = firstOperand.ToString();
                    currentOperator = Operators.None;
                }
            }
        }
    }
}