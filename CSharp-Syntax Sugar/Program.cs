
using System;
using System.Collections.Generic;
using System.IO;

namespace CSharp_Syntax_Sugar
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    #region 扩展方法

    static class IntExt
    {
        public static void SayHello(this int para)
        {
            Console.WriteLine("hello c#, i'm integer!!!");
        }
    }

    #endregion

    class Program
    {
        #region 自动属性
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Name { get; set; }

        public static void SayHello(string name)
        {
            Console.WriteLine("hello " + name);
        }
        #endregion

        static void Main(string[] args)
        {
            #region 类初始化器
            Student s = new Student
            {
                Name = "小明",
                Age = 18
            };
            #endregion

            #region 类型推断+集合初始化器
            var students = new List<Student>
        {
            new Student{Name = "丽丽", Age = 18},
            new Student{Name = "大宏", Age = 15}
        };
            #endregion

            #region 匿名类
            var b = new { Name = "小明", Age = 20 };
            #endregion

            #region using

            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("c:/1.txt");
                sw.WriteLine("hello c#");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
            //////////////////////////////////////////
            using (sw = new StreamWriter("c:/2.txt"))
            {
                sw.WriteLine("hello using");
            }

            #endregion

            #region 字符串拼接
            var name = "john";
            Console.WriteLine(string.Format("hello {0}", name));
            Console.WriteLine($"hello {name}");
            #endregion

            #region 扩展方法调用
            var age = 18;
            age.SayHello();
            #endregion

            #region null条件运算符
            // ?.（用于判断对象属性是否为Null）
            Student x = null;
            var y = x?.Age;
            Console.WriteLine(y);

            // ?? m不为Null，赋值m，常用于数据库操作
            string m = null;
            string n = m ?? "我是默认值";
            Console.WriteLine(n);
            #endregion

            #region lambda表达式
            students.ForEach(k => Console.WriteLine(k.Name));
            #endregion

            #region 泛型委托

            var foo = new Action<string>(SayHello);
            foo.Invoke("Action");

            var bar = new Func<int, int, int>((c, d) => { return c + d; } );
            Console.WriteLine(bar.Invoke(99, 1));

            #endregion

            Console.Read();
        }

    }
}
