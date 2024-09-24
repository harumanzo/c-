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
                MessageBox.Show("로그인에 성공했습니다.", "로그인");
            }
            else {
                MessageBox.Show("로그인에 실패했습니다.", "로그인");
            }

        }
    }
}