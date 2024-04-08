using OfficeOpenXml;
using System.Data;
using System.Drawing.Drawing2D;
using System.IO;

namespace QLCHBanHoaQuaWF;

public static class MyExtensionMethods
{
    public static void ExportToExcel(this DataGridView dataGridView, string filePath)
    {
        using (ExcelPackage package = new ExcelPackage())
        {
            ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Sheet1");
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if (!dataGridView.Columns[i].Visible)
                {
                    continue;
                }
                worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
            }

            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    if (!dataGridView.Columns[j].Visible)
                    {
                        continue;
                    }
                    worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value.ToString();
                }
            }

            FileInfo fileInfo = new FileInfo(filePath);
            package.SaveAs(fileInfo);
        }
    }

    public static void ImportFromExcel(this DataGridView dataGridView, string filePath)
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
    public static void SetBorderRadius(this Control control, int borderRadius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
        path.AddArc(control.Width - borderRadius, 0, borderRadius, borderRadius, 270, 90);
        path.AddArc(control.Width - borderRadius, control.Height - borderRadius, borderRadius, borderRadius, 0, 90);
        path.AddArc(0, control.Height - borderRadius, borderRadius, borderRadius, 90, 90);

        control.Region = new Region(path);
    }
}