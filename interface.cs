using System;
using System.Collections.Generic;
using System.IO;


namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Say();

            var cat = new Cat();
            cat.Say();

            var bad = new BadDemo();
            bad.AnimalSay(dog);

            var good = new GoodDemo();
            good.AnimalSay(dog);

            foreach (var file in GetFiles())
            {
                Console.WriteLine(file);
            }

            Console.ReadKey();
        }

        // 接口的小demo
        public static ICollection<string> GetFiles()
        {
            var files = Directory.GetFiles(@"c:\", "*.*");

            return files;
        }
    }
    
    public interface IAnimal
    {
        void Say();
    }

    // 如果类继承了某接口，就必须实现其成员,接口起到约束的作用
    class Dog:IAnimal   
    {
        public void Say()
        {
            Console.WriteLine("汪汪");
        }
    }

    class Cat:IAnimal
    {
        public void Say()
        {
            Console.WriteLine("喵喵");
        }
    }
    
    class BadDemo
    {
        public void AnimalSay(Cat cat)
        {
            cat.Say();
        }

        public void AnimalSay(Dog dog)
        {
            dog.Say();
        }
    }

    class GoodDemo
    {
        // 接口作为一种引用类型，可以指向其实现类。
        // 此例接口相当于C++的基类
        public void AnimalSay(IAnimal a)
        {
            a.Say();
        }
    }
    
}


