using Microsoft.VisualBasic.ApplicationServices;
using System.Data.OleDb;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entites;


namespace WinFormsApp2.Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }



        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Username and password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (textBox2.Text != textBox3.Text)
            {
                MessageBox.Show("Passwords do not match", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
            else
            {
                try
                {
                    using (var context = new ApplicationDbContext())
                    {
                        // Create a new user
                        var newUser = new user_pass
                        {
                            username = textBox1.Text,
                            password = textBox2.Text
                        };

                        // Add the user to the database
                        context.user_pass.Add(newUser);
                        context.SaveChanges();

                        // Clear the text boxes
                        textBox1.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";

                        MessageBox.Show("User registered successfully", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (textBox1.Text == "" && textBox2.Text == "" && textBox3.Text == "")
        //    {
        //        MessageBox.Show("username and password fields are empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    }
        //    else if (textBox1.Text == textBox3.Text)
        //    {
        //        con.Open();
        //        string query = "INSERT INTO tbl_users VALUES  VALUES ('" + textBox1.Text + "','" + textBox2.Text + "')";
        //        cmd = new OleDbCommand(query, con);
        //        cmd.ExecuteNonQuery();
        //        con.Close();

        //        textBox1.Text = "";
        //        textBox2.Text = "";
        //        textBox3.Text = "";

        //        MessageBox.Show("User registered successfully", "Registration success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        MessageBox.Show("passwords do not match", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        textBox2.Text = "";
        //        textBox3.Text = "";
        //        textBox2.Focus();



        //    }
        //}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
                textBox3.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new MainLoginform().Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
