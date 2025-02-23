using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Microsoft.VisualBasic.ApplicationServices;
using WinFormsApp2.DAL.Entites;
using WinFormsApp2.DAL.Database;
using Microsoft.Data.SqlClient;


namespace WinFormsApp2.Forms
{
    public partial class MainLoginform : Form
    {
        
     

        public MainLoginform()
                {
                    InitializeComponent();
            con = new SqlConnection(connectionString);
                }

        ///////////////////////////////////
        //OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\ITIintensivecourse.net\\projectEF\\WinFormsApp2\\WinFormsApp2\\bin\\Debug\\db_users.mdb");
        //OleDbCommand cmd = new OleDbCommand();
        //OleDbDataAdapter da = new OleDbDataAdapter();
        
        /// //////////////////////////////////////////////
        
        // SQL Server connection string
        private string connectionString = @"Server=.;Database=new;Trusted_Connection=True;TrustServerCertificate=True;";

        // SQL Connection and Command objects
        private SqlConnection con;
        private SqlCommand cmd;

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                // Query to check if the username and password match
                string query = "SELECT * FROM user_pass WHERE username = @username AND password = @password";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", textBox1.Text); // Use parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@password", textBox2.Text);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

       
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void MainLoginform_Load(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    con.Open();
        //    string query = "SELECT * FROM tbl_users WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
        //    cmd = new OleDbCommand(query, con);
        //    OleDbDataReader dr = cmd.ExecuteReader();

        //    if (dr.Read() == true)
        //    {
        //        new MainMenu().Show();
        //        this.Hide();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Invalid username or password", "Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        textBox1.Text = "";
        //        textBox2.Text = "";
        //        textBox1.Focus();
        //    }



        //}

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
    }
}
