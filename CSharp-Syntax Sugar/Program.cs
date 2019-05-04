
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

            #region 构造函数调用其他构造函数
            var cls = new Test();
            #endregion

            #region 问号的用法
            // 1、三目操作符
            int Age = 16;
            Console.WriteLine(age > 18 ? "成年" : "未成年");

            // 2、可空类型操作符（常用于ORM）
            // 编译器报错，值类型不能被赋为null
            // DateTime dt = null;
            DateTime? dt = null;

            // 3、空合并运算符
            string str1 = null;
            string str2 = str1 ?? "str1为空";
            // 等同于
            if (str1 != null)
            {
                str2 = str1;
            }
            else
            {
                str2 = "str1为空";
            }
                       
            // 对象null检测
            cls?.Show();
            // 等同于以下
            if (null != cls)
            {
                cls.Show();
            }


            #endregion

            Console.Read();
        }
    }

    class Test
    {
        public Test():this(1,1)
        {
            Console.WriteLine("默认构造函数");
        }

        public Test(int x, int y)
        {
            Console.WriteLine("自定义构造函数");
        }

        public void Show()
        {
        }
    }
}
