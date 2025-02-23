using WinFormsApp2.DAL.Database;

namespace WinFormsApp2.Forms
{
    public partial class MainLoginform : Form
    {



        public MainLoginform()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = context.user_pass
                        .FirstOrDefault(u => u.username == textBox1.Text && u.password == textBox2.Text);

                    if (user != null)
                    {
                        // Login successful
                        new MainMenu().Show();
                        this.Hide();
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox1.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainLoginform_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Focus();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new loginForm().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
