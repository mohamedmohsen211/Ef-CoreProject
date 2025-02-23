using System.Data;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.Forms;

namespace WinFormsApp2
{
    public partial class MainMenu : Form
    {
        private Form activef;
        public MainMenu()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                var result = context.Employees.Where(p => p.Id < 10);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
        }


        private void parrotPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void openchildform(Form childform, object btnSender)
        {
            if (activef != null)
            {
                activef.Close();

            }
            activef = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            this.panelshow.Controls.Add(childform);
            this.panelshow.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            openchildform(new Editform(), sender);

        }
        private void button7_Click_1(object sender, EventArgs e)
        {
            openchildform(new AddFileform(), sender);

        }
        private void button6_Click_1(object sender, EventArgs e)
        {

            openchildform(new Loggedin(), sender);

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aloneButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openchildform(new Export(), sender);

        }

        private void panelshow_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


