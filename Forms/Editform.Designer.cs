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
            gender = new TextBox();
            email = new TextBox();
            last_name = new TextBox();
            first_name = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Add = new Button();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button5
            // 
            button5.Location = new Point(333, 283);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(96, 32);
            button5.TabIndex = 25;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(333, 196);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(96, 32);
            button4.TabIndex = 24;
            button4.Text = "Update";
            button4.UseVisualStyleBackColor = true;
            // 
            // gender
            // 
            gender.Location = new Point(120, 367);
            gender.Margin = new Padding(4);
            gender.Name = "gender";
            gender.Size = new Size(127, 29);
            gender.TabIndex = 23;
            // 
            // email
            // 
            email.Location = new Point(120, 283);
            email.Margin = new Padding(4);
            email.Name = "email";
            email.Size = new Size(127, 29);
            email.TabIndex = 22;
            // 
            // last_name
            // 
            last_name.Location = new Point(120, 196);
            last_name.Margin = new Padding(4);
            last_name.Name = "last_name";
            last_name.Size = new Size(127, 29);
            last_name.TabIndex = 21;
            // 
            // first_name
            // 
            first_name.Location = new Point(120, 104);
            first_name.Margin = new Padding(4);
            first_name.Name = "first_name";
            first_name.Size = new Size(127, 29);
            first_name.TabIndex = 20;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 378);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 21);
            label4.TabIndex = 19;
            label4.Text = "gender";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 294);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 18;
            label3.Text = "email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 207);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 17;
            label2.Text = "Last_Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 16;
            label1.Text = "Fname";
            // 
            // Add
            // 
            Add.Location = new Point(333, 104);
            Add.Margin = new Padding(4);
            Add.Name = "Add";
            Add.Size = new Size(96, 32);
            Add.TabIndex = 15;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(463, 104);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(499, 386);
            dataGridView1.TabIndex = 26;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(259, 26);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(367, 29);
            comboBox1.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 29);
            label5.Name = "label5";
            label5.Size = new Size(51, 21);
            label5.TabIndex = 28;
            label5.Text = "page :";
            // 
            // Editform
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 499);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(gender);
            Controls.Add(email);
            Controls.Add(last_name);
            Controls.Add(first_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Add);
            Name = "Editform";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button5;
        private Button button4;
        private TextBox gender;
        private TextBox email;
        private TextBox last_name;
        private TextBox first_name;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Add;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Label label5;
    }
}
