namespace RM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (MainClass.IsValidUser(txtUser.Text, txtPass.Text)== false)
            {

            } 
        }
    }
}