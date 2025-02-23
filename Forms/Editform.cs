using ClosedXML.Excel;
using System.Data;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entites;

namespace WinFormsApp2
{

    public partial class Editform : Form
    {
        private string selectedFilePath;

        public Editform()
        {
            InitializeComponent();
        }
        private void LoadDataFromDatabase()
        {
            using var dbContext = new ApplicationDbContext();
            dataGridView1.DataSource = dbContext.Employees.ToList();
        }
        private void LoadExcelFile(string filePath)
        {
            try
            {
                using var workbook = new XLWorkbook(filePath);
                var worksheet = workbook.Worksheets.First();
                var dataTable = new DataTable();

                // Add Columns
                foreach (var cell in worksheet.Row(1).CellsUsed())
                {
                    dataTable.Columns.Add(cell.Value.ToString());
                }

                // Add Rows
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
                MessageBox.Show($"Failed to load Excel file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        //to add excel file
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
        //to Show avaliable sheets in excel file
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

        //to chose sheet
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


                foreach (var cell in worksheet.Row(1).CellsUsed())
                {
                    dataTable.Columns.Add(cell.Value.ToString());
                }


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
        //function to add data to DB
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
                        first_name = row[1].ToString(),
                        last_name = row[2].ToString(),
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
        //btn that use func that save data to db 
        private void button2_Click(object sender, EventArgs e)
        {
            SaveToDatabase();
            LoadDataFromDatabase();
        }
        //to catch the textbox and use it
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                first_name.Text = dataGridView1.SelectedRows[0].Cells["first_name"].Value.ToString();
                last_name.Text = dataGridView1.SelectedRows[0].Cells["last_name"].Value.ToString();
                email.Text = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString();
                gender.Text = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString();
            }
        }


        //add btn to add new record

        private void button3_Click(object sender, EventArgs e)
        {
            using var dbContext = new ApplicationDbContext();
            var newEmployee = new Employee
            {
                first_name = first_name.Text,
                last_name = last_name.Text,
                email = email.Text,
                gender = gender.Text
            };

            dbContext.Employees.Add(newEmployee);
            dbContext.SaveChanges();
            MessageBox.Show("New record added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataFromDatabase();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        //Update btn to update the chosen record
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using var dbContext = new ApplicationDbContext();
                var employee = dbContext.Employees.Find(id);
                if (employee != null)
                {
                    employee.first_name = first_name.Text;
                    employee.last_name = last_name.Text;
                    employee.email = email.Text;
                    employee.gender = gender.Text;

                    dbContext.SaveChanges();
                    MessageBox.Show("Record updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to update!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //deltet btn to delete the chosen record
        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["Id"].Value);

                using var dbContext = new ApplicationDbContext();
                var employee = dbContext.Employees.Find(id);
                if (employee != null)
                {
                    dbContext.Employees.Remove(employee);
                    dbContext.SaveChanges();
                    MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataFromDatabase();
                }
            }
            else
            {
                MessageBox.Show("Please select a record to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
