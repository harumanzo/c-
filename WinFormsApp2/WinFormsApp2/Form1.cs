namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void signinbutton_Click(object sender, EventArgs e)
        {
            string userid = Identity.Text;
            string userpw = password.Text;

            if (userid.Equals("MyId") && userpw.Equals("Mypassword"))
            {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���");
            }
            else {
                MessageBox.Show("�α��ο� �����߽��ϴ�.", "�α���");
            }

        }
    }
}