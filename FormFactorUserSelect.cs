namespace FormFactorSystem
{
    public partial class FormFactorUserSelect : Form
    {
        public FormFactorUserSelect()
        {
            InitializeComponent();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            var credentials = new
            {
                username = "admin",
                password = "admin12345"
            };

            if (txtPassword.Text == credentials.password && txtUsername.Text == credentials.username)
            {
                FormFactorAdminDashboard newForm = new FormFactorAdminDashboard();
                newForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Either the username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
