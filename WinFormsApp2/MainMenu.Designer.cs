namespace WinFormsApp2
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            panel1 = new Panel();
            aloneButton2 = new ReaLTaiizor.Controls.AloneButton();
            aloneButton1 = new ReaLTaiizor.Controls.AloneButton();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            button2 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            panelshow = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(aloneButton2);
            panel1.Controls.Add(aloneButton1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 78);
            panel1.TabIndex = 5;
            // 
            // aloneButton2
            // 
            aloneButton2.BackColor = Color.Transparent;
            aloneButton2.EnabledCalc = true;
            aloneButton2.Font = new Font("Segoe UI", 9F);
            aloneButton2.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton2.Location = new Point(1092, 3);
            aloneButton2.Name = "aloneButton2";
            aloneButton2.Size = new Size(28, 28);
            aloneButton2.TabIndex = 14;
            aloneButton2.Text = "_";
            // 
            // aloneButton1
            // 
            aloneButton1.BackColor = Color.Transparent;
            aloneButton1.EnabledCalc = true;
            aloneButton1.Font = new Font("Segoe UI", 9F);
            aloneButton1.ForeColor = Color.FromArgb(124, 133, 142);
            aloneButton1.Location = new Point(1126, 3);
            aloneButton1.Name = "aloneButton1";
            aloneButton1.Size = new Size(28, 28);
            aloneButton1.TabIndex = 13;
            aloneButton1.Text = "X";
            aloneButton1.Click += aloneButton1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Lavender;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(170, 732);
            panel2.TabIndex = 7;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.WindowText;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_export_50;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(4, 363);
            button1.Margin = new Padding(4, 4, 4, 4);
            button1.Name = "button1";
            button1.Size = new Size(225, 90);
            button1.TabIndex = 24;
            button1.Text = "    Export";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSlateGray;
            panel3.Controls.Add(bigLabel1);
            panel3.Location = new Point(1, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(168, 78);
            panel3.TabIndex = 13;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(13, 13);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(100, 46);
            bigLabel1.TabIndex = 24;
            bigLabel1.Text = "3lraik";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.WindowText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_exit_sign_50;
            button2.ImageAlign = ContentAlignment.BottomCenter;
            button2.Location = new Point(-55, 512);
            button2.Margin = new Padding(4, 4, 4, 4);
            button2.Name = "button2";
            button2.Size = new Size(216, 87);
            button2.TabIndex = 25;
            button2.Text = "    Exit";
            button2.TextAlign = ContentAlignment.BottomRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.Cursor = Cursors.Hand;
            button8.FlatAppearance.BorderColor = SystemColors.WindowText;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.icons8_modify_50;
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 276);
            button8.Margin = new Padding(4, 4, 4, 4);
            button8.Name = "button8";
            button8.Size = new Size(229, 78);
            button8.TabIndex = 22;
            button8.Text = "    Edit";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderColor = SystemColors.WindowText;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.icons8_add_50;
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(4, 190);
            button7.Margin = new Padding(4, 4, 4, 4);
            button7.Name = "button7";
            button7.Size = new Size(229, 77);
            button7.TabIndex = 21;
            button7.Text = "    Add File";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click_1;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.WindowText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 99);
            button6.Margin = new Padding(4, 4, 4, 4);
            button6.Name = "button6";
            button6.Size = new Size(229, 83);
            button6.TabIndex = 19;
            button6.Text = "    Home";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click_1;
            // 
            // panelshow
            // 
            panelshow.Location = new Point(167, 77);
            panelshow.Name = "panelshow";
            panelshow.Size = new Size(991, 539);
            panelshow.TabIndex = 13;
            panelshow.Paint += panelshow_Paint;
            // 
            // MainMenu
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1158, 616);
            Controls.Add(panelshow);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Button button6;
        private ReaLTaiizor.Controls.AloneButton aloneButton1;
        private ReaLTaiizor.Controls.AloneButton aloneButton2;
        private Button button7;
        private Button button8;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Button button2;
        private Panel panel3;
        private Panel panelshow;
        private Button button1;
    }
}