using System;


namespace 泛型
{
    class Program
    {
        static void Main(string[] args)
        {
            var boy = "莉莉";
            var girl = "小明";
            Swap(ref boy, ref girl);
            Console.WriteLine(boy);
            Console.WriteLine(girl);

            var thisyear = 2015;
            var lastyear = 2016;
            Swap(ref thisyear, ref lastyear);
            Console.WriteLine(thisyear);
            Console.WriteLine(lastyear);

            Console.ReadKey();
        }

        static void Swap<T>(ref T a, ref T b)
        {
            var temp = a;
            a = b;
            b = temp;
        }
    }
}
