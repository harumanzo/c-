
using System;
using System.Windows.Forms;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private int findNumber = 0;
        private int chance = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            findNumber = rand.Next(1, 21);
            chance = 10;
            display.Text = "������ڸ� �Է��ϼ���";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            int inputNumber = Int32.Parse(textBox.Text);

            if (inputNumber == findNumber)
            {
                display.Text = "�����Դϴ�";
            }
            else
            {
                chance--;
                display.Text = "��ȸ�� " + chance + "�� ���ҽ��ϴ�";
            }

            if (chance <= 0)
            {
                display.Text = "tlfvo";
            }

        }

    }
}