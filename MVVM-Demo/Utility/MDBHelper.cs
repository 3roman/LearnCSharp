using System.Data;
using System.Data.OleDb;

namespace MVVMDemo.Utility
{
    class MDBHelper
    {
        public static DataTable GetDataTable(string fileName, string sql)
        {
            var connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + fileName + ";";
            var dt = new DataTable();
            using (var connection = new OleDbConnection(connString))
            {
                connection.Open();
                var adapter = new OleDbDataAdapter(sql, connection);
                adapter.Fill(dt);
            }

            return dt;
        }
    }     

}
