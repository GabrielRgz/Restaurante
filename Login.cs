namespace Restaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void lblnombre_Click_1(object sender, EventArgs e)
        {


        }
        private void rjTextBox1__TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Principal principal = new Principal();
            principal.Show();
            this.Hide();
        }
    }
}