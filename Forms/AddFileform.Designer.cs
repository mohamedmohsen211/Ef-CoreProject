namespace WinFormsApp2
{
    partial class AddFileform
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
            airButton4 = new ReaLTaiizor.Controls.AirButton();
            label1 = new Label();
            airButton3 = new ReaLTaiizor.Controls.AirButton();
            airButton1 = new ReaLTaiizor.Controls.AirButton();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // airButton4
            // 
            airButton4.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton4.Font = new Font("Segoe UI", 9F);
            airButton4.Image = null;
            airButton4.Location = new Point(357, 94);
            airButton4.Name = "airButton4";
            airButton4.NoRounding = false;
            airButton4.Size = new Size(174, 32);
            airButton4.TabIndex = 18;
            airButton4.Text = "TestConsole";
            airButton4.Transparent = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 9);
            label1.Name = "label1";
            label1.Size = new Size(106, 21);
            label1.TabIndex = 15;
            label1.Text = "Choose Page :";
            // 
            // airButton3
            // 
            airButton3.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton3.Font = new Font("Segoe UI", 9F);
            airButton3.Image = null;
            airButton3.Location = new Point(797, 37);
            airButton3.Name = "airButton3";
            airButton3.NoRounding = false;
            airButton3.Size = new Size(148, 70);
            airButton3.TabIndex = 17;
            airButton3.Text = "Import Data";
            airButton3.Transparent = false;
            airButton3.Click += airButton3_Click;
            // 
            // airButton1
            // 
            airButton1.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            airButton1.Font = new Font("Segoe UI", 9F);
            airButton1.Image = null;
            airButton1.Location = new Point(35, 37);
            airButton1.Name = "airButton1";
            airButton1.NoRounding = false;
            airButton1.Size = new Size(162, 70);
            airButton1.TabIndex = 16;
            airButton1.Text = "Add";
            airButton1.Transparent = false;
            airButton1.Click += AirButton1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(224, 37);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(545, 29);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 133);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(910, 353);
            dataGridView1.TabIndex = 13;
            // 
            // AddFileform
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 499);
            Controls.Add(airButton4);
            Controls.Add(label1);
            Controls.Add(airButton3);
            Controls.Add(airButton1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Name = "AddFileform";
            Text = "AddFileform";
            //Load += this.AddFileform_Load_2;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.AirButton airButton4;
        private Label label1;
        private ReaLTaiizor.Controls.AirButton airButton3;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
    }
}