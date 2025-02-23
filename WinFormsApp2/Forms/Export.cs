using ClosedXML.Excel;
using System.Reflection;
using WinFormsApp2.DAL.Database;
using WinFormsApp2.DAL.Entites;

namespace WinFormsApp2.Forms
{
    public partial class Export : Form
    {
        private void LoadDataFromDatabase()
        {
            var dbContext = new ApplicationDbContext();
            dataGridView1.DataSource = dbContext.Employees.ToList();
        }
        public Export()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }
        public class ExcelExporter
        {
            private readonly ApplicationDbContext _context;

            public ExcelExporter(ApplicationDbContext context)
            {
                _context = context;
            }

            public void ExportToExcel<T>(string filePath) where T : class
            {
                var dbSet = _context.Set<T>();

                var data = dbSet.ToList();
                if (data.Count == 0)
                {
                    throw new Exception("No data found to export.");
                }

                using (var workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add(typeof(T).Name);
                    int row = 1;

                    var properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

                    for (int col = 0; col < properties.Length; col++)
                    {
                        worksheet.Cell(row, col + 1).Value = properties[col].Name;
                        worksheet.Cell(row, col + 1).Style.Font.Bold = true;
                    }

                    foreach (var item in data)
                    {
                        row++;
                        for (int col = 0; col < properties.Length; col++)
                        {
                            worksheet.Cell(row, col + 1).Value = properties[col].GetValue(item)?.ToString();
                        }
                    }

                    worksheet.Columns().AdjustToContents();

                    workbook.SaveAs(filePath);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Files|*.xlsx";
                saveFileDialog.Title = "Save an Excel File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (var context = new ApplicationDbContext())
                        {
                            var exporter = new ExcelExporter(context);
                            exporter.ExportToExcel<Employee>(saveFileDialog.FileName);

                            MessageBox.Show("Export completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}", "Export Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
