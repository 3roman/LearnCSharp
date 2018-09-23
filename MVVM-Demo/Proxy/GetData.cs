using MVVMDemo.DTO;
using MVVMDemo.Utility;
using System.Collections.Generic;

namespace MVVMDemo.Proxy
{
    class GetData
    {
        public static List<Student> GetStudentInfo()
        {
            var dt = MDBHelper.GetDataTable("data.mdb", "SELECT * FROM Student");

            return Converter.DataTable2List<Student>(dt);
        }
    }
}
