using System;

namespace CSharp_Attribute
{
    [Version(MajorVersion =1, MinorVersion = 0, Description ="测试版")]
    class Program
    {
        //[Version(MajorVersion = 1, MinorVersion = 0, Description = "测试版")]
        static void Main(string[] args)
        {

            var p1 = new Person()
            {
               Age = 22
            };

            if (RequiredAttribute.IsPropertyRequired(p1))
            {
                Console.WriteLine("全部已经赋值");
            }
            else
            {
                Console.WriteLine("存在未赋值");
            }


            var p2 = new Person()
            {
                Name = "Tom",
                Age=28,
                Married = true
            };

            if (RequiredAttribute.IsPropertyRequired(p2))
            {
                Console.WriteLine("全部已经赋值");
            }
            else
            {
                Console.WriteLine("存在未赋值");
            }

            var attribute = (VersionAttribute)Attribute.GetCustomAttribute(typeof(Program), typeof(VersionAttribute));

            Console.WriteLine(attribute.Description);

            Console.Read();
        }
    }
}
