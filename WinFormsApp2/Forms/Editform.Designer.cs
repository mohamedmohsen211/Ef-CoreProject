namespace WinFormsApp2
{
    partial class Editform
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button5 = new Button();
            button4 = new Button();
            email = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Add = new Button();
            dataGridView1 = new DataGridView();
            gender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(259, 202);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 25;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click_1;
            // 
            // button4
            // 
            button4.Location = new Point(259, 140);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // email
            // 
            email.Location = new Point(93, 202);
            email.Name = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 22;
            // 
            // last_name
            // 
            last_name.Location = new Point(93, 140);
            last_name.Name = "last_name";
            last_name.Size = new Size(100, 23);
            last_name.TabIndex = 21;
            // 
            // first_name
            // 
            first_name.Location = new Point(93, 74);
            first_name.Name = "first_name";
            first_name.Size = new Size(100, 23);
            first_name.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 270);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 19;
            label4.Text = "Gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 206);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 18;
            label3.Text = "E-mail";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 144);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 17;
            label2.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 77);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 16;
            label1.Text = "First Name";
            // 
            // Add
            // 
            Add.Location = new Point(259, 74);
            Add.Name = "Add";
            Add.Size = new Size(75, 23);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(360, 74);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(388, 276);
            dataGridView1.TabIndex = 26;
            // 
            // gender
            // 
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Male", "Female" });
            gender.Location = new Point(93, 267);
            gender.Name = "gender";
            gender.Size = new Size(100, 23);
            gender.TabIndex = 27;
            gender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Editform
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 356);
            Controls.Add(gender);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(email);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Margin = new Padding(2);
            Name = "Editform";
            Text = "Form1";
            Load += Editform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private TextBox email;
        private TextBox last_name;
        private TextBox first_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private DataGridView dataGridView1;
        private ComboBox gender;
    }
}
