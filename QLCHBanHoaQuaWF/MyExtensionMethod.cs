using OfficeOpenXml;
using System.Data;
using System.Windows.Forms;

namespace QLCHBanHoaQuaWF;

public static class MyExtensionMethod
{
    public static void ExportToExcel(this Form form,DataGridView dataGridView,string filePath)
    {
        using (ExcelPackage package = new ExcelPackage())
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            FileInfo fileInfo = new FileInfo(filePath);
            package.SaveAs(fileInfo);
        }
    }

    public static void ImportFromExcel(this Form form, DataGridView dataGridView, string filePath)
    {
        FileInfo fileInfo = new FileInfo(filePath);
        using (ExcelPackage package = new ExcelPackage(fileInfo))
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets[0];

            int rowCount = worksheet.Dimension.Rows;
            int columnCount = worksheet.Dimension.Columns;

            DataTable dataTable = new DataTable();

            for (int row = 1; row <= rowCount; row++)
            {
                if (row == 1)
                {
                    for (int column = 1; column <= columnCount; column++)
                    {
                        dataTable.Columns.Add(worksheet.Cells[row, column].Value.ToString());
                    }
                }
                else
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int column = 1; column <= columnCount; column++)
                    {
                        dataRow[column - 1] = worksheet.Cells[row, column].Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            dataGridView.DataSource = dataTable;
        }
    }
}