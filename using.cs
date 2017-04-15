using System;
using System.IO;


namespace using关键字
{
    class Program
    {

        static void Main(string[] args)
        {
            // using内的对象在花括号结束后自动释放，一般用于非托管资源的释放，比如文件、注册表、套接字
            using (var data = new FileStream(@"C:\log.txt", FileMode.Open))
            {

            }


            Console.ReadKey();

        }
    }
}
