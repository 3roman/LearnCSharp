using System;
using System.Data;
using System.Data.OleDb;
using System.IO;


namespace ExcelToDataTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var dt = GetWorkSheet(@"data.xlsx", "IH250");

            Console.ReadLine();
        }


        public static DataTable GetWorkSheet(string filePath, string workSheetName)
        {
            var dataTable = new DataTable();
            var connection = new OleDbConnection(GenerateConnectionString(filePath));
            var adapter = new OleDbDataAdapter("SELECT * FROM [" + workSheetName + "$]", connection);
            try
            {
                connection.Open();
                adapter.FillSchema(dataTable, SchemaType.Mapped);
                adapter.Fill(dataTable);
                connection.Close();
                dataTable.TableName = workSheetName;
            }
            catch (Exception)
            {
                throw;
            }
            
            return dataTable;
        }

        public static string GenerateConnectionString(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception("指定文件不存在！");
            }

            return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filePath + ";Extended Properties=\"Excel 12.0;HDR=Yes;IMEX=1\"";
        }
    }
}
