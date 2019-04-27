using System;
using System.Diagnostics;
using System.Reflection;

namespace CSharp_Attribute
{
    class Program
    {
        //[Version(MajorVersion = 1, MinorVersion = 0, Description = "测试版")]
        static void Main(string[] args)
        {
            MyClass.Foo();
            MyClass.SayHello();

            // 通过反射获取attribute信息
            HelpAttribute ha;
            var attributes = typeof(MyClass).GetCustomAttributes();
            foreach (var attr in attributes)
            {
                // 类型不兼容返回null
                ha = attr as HelpAttribute;
                if (null!=ha)
                {
                    Console.WriteLine(ha.HelpMessage);
                    Console.WriteLine(ha.MajorVersion);
                }

            }

            Console.Read();
        }
    }


    [Help("This is a test class", MajorVersion =1)]
    class MyClass
    {
        [Conditional("DEBUG")]
        public static void Foo()
        {
            Console.WriteLine("只有在Debug模式下，该函数才会被实际调用");
        }

        // 加true参数调用过时方法会报错
        //[Obsolete("奥巴马下台了，不要再教他总统", true)]
        [Obsolete("奥巴马下台了，不要再教他总统")]
        public static void SayHello()
        {
            Console.WriteLine("hello 奥巴马总统");
        }
    }

    // 该attribute只能用来修饰类，且只能一次修饰一个类,不会自动传递到派生类
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited =false)]
    class HelpAttribute:Attribute
    {
        public int MajorVersion { get; set; }

        private string _helpMessage;

        public string HelpMessage
        {
            get { return _helpMessage; }
            set { _helpMessage = value; }
        }

        public HelpAttribute(string para)
        {
            _helpMessage = para;  
        }
    }
}
