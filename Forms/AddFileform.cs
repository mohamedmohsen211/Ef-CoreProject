using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entites;

namespace WinFormsApp2
{
    public partial class AddFileform : Form
    {
        //private Form activef;
        private string selectedFilePath;
        public AddFileform()
        {
            InitializeComponent();
        }
        private void form2(string filePath)
        {
            try
            {
                using var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheets.First();
                var dataTable = new DataTable();

                // Add columns
                foreach (var cell in worksheet.Row(1).Cells())
                {
                    dataTable.Columns.Add(cell.Value.ToString());
                }

                // Add rows
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    var newRow = dataTable.NewRow();
                    int cellIndex = 0;
                    foreach (var cell in row.Cells())
                    {
                        newRow[cellIndex++] = cell.Value.ToString();
                    }
                    dataTable.Rows.Add(newRow);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                LoadSheetsIntoComboBox(selectedFilePath);
            }
        }
        private void LoadSheetsIntoComboBox(string filePath)
        {
            try
            {
                using var workbook = new XLWorkbook(filePath);

                comboBox1.Items.Clear();

                foreach (var sheet in workbook.Worksheets)
                {
                    comboBox1.Items.Add(sheet.Name);
                }

                if (comboBox1.Items.Count > 0)
                {
                    comboBox1.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || string.IsNullOrEmpty(selectedFilePath))
                return;

            string selectedSheet = comboBox1.SelectedItem.ToString();

            try
            {
                using var workbook = new XLWorkbook(selectedFilePath);
                var worksheet = workbook.Worksheet(selectedSheet);
                var dataTable = new DataTable();

                // Add columns
                foreach (var cell in worksheet.Row(1).CellsUsed())
                {
                    dataTable.Columns.Add(cell.Value.ToString());
                }

                // Add rows
                foreach (var row in worksheet.RowsUsed().Skip(1))
                {
                    var newRow = dataTable.NewRow();
                    int cellIndex = 0;
                    foreach (var cell in row.CellsUsed())
                    {
                        newRow[cellIndex++] = cell.Value.ToString();
                    }
                    dataTable.Rows.Add(newRow);
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load sheet: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToDatabase()
        {
            if (dataGridView1.DataSource is DataTable dataTable)
            {
                using var dbContext = new ApplicationDbContext();

                bool ignoreFirstColumn = dataTable.Columns.Count > 0 && dataTable.Columns[0].ColumnName == "Id";

                foreach (DataRow row in dataTable.Rows)
                {
                    var record = new Employee
                    {
                        Id = ignoreFirstColumn ? int.TryParse(row["Id"].ToString(), out int Id) ? Id : 0 : 0,
                        //last_name = row["last_name"].ToString(),
                        //first_name = row["first_name"].ToString(),
                        //email = row["email"].ToString(),
                        //gender = row["gender"].ToString(),

                        last_name = row[1].ToString(),
                        first_name = row[2].ToString(),
                        email = row[3].ToString(),
                        gender = row[4].ToString(),


                    };

                    dbContext.Employees.Add(record);
                }

                dbContext.SaveChanges();
                MessageBox.Show("Data successfully exported to SQL!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No data to export!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SaveToDatabase();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                //var employee = new Employee { first_name = "IT", last_name = "mm" , email="dd" , gender="Male" };
                //context.Employees.Add(employee);
                //context.SaveChanges();
                var result = context.Employees.Where(p => p.Id < 10);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }

            }
        }

        private void AirButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
                LoadSheetsIntoComboBox(selectedFilePath);
            }
        }

        private void airButton3_Click(object sender, EventArgs e)
        {
            SaveToDatabase();
        }

        private void airButton4_Click(object sender, EventArgs e)
        {
            using (var context = new ApplicationDbContext())
            {
                //var employee = new Employee { first_name = "IT", last_name = "mm" , email="dd" , gender="Male" };
                //context.Employees.Add(employee);
                //context.SaveChanges();
                var result = context.Employees.Where(p => p.Id < 10);
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }


            }
        }
        //private void airButton1_Click(object sender, EventArgs e)
        //{

        //}

        //private void AddFileform_Load(object sender, EventArgs e)
        //{
        //    OpenFileDialog openFileDialog = new()
        //    {
        //        Filter = "Excel Sheet (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
        //    };

        //    if (openFileDialog.ShowDialog() == DialogResult.OK)
        //    {
        //        selectedFilePath = openFileDialog.FileName;
        //        LoadSheetsIntoComboBox(selectedFilePath);
        //    }
        //}
    }
    
}
