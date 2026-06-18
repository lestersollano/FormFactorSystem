namespace FormFactorSystem
{
    public partial class UserSelect : Form
    {
        public UserSelect()
        {
            InitializeComponent();
            RAMDatabase ramdatabase = new RAMDatabase();
            ramdatabase.Initialize();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {

            // DELETE LATER: This is just for testing purposes to bypass the login screen. Remove this before final submission.
            this.Hide();
            AdminDashboard newForm = new AdminDashboard();
            var result = newForm.ShowDialog();
            this.Close();
            return;

            var credentials = new
            {
                username = "admin",
                password = "admin12345"
            };

            if (txtPassword.Text == credentials.password && txtUsername.Text == credentials.username)
            {
                //this.Hide();
                //AdminDashboard newForm = new AdminDashboard();
                //var result = newForm.ShowDialog();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Either the username or password is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
