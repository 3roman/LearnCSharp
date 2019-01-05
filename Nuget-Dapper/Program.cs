using System;
using System.Linq;
using Dapper;
using System.Data.SQLite;

namespace Nuget_Dapper
{
    class Program
    {
        const string ConnectionString = "Data Source=school.db";


        static void Main(string[] args)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                var teachers = conn.Query<Teacher>("SELECT * FROM tbl_teacher");
                teachers.ToList().ForEach(x =>
                {
                    Console.WriteLine(string.Format("{0}-{1}-{2}-{3}",
                        x.ID, 
                        x.Name, 
                        x.Age,
                        x.Gender ? "男":"女"));
                });

                Console.Read();
            }
        }
    }
}
