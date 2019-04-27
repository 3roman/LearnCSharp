using MyDll;
using System;

namespace Nuget_Costura
{
    class Program
    {
        static void Main(string[] args)
        {
            Hangch.ShowMessage();


            double t = 0;
            var r = 0;
            UEwasp.SETSTD_WASP(97);
            while (true)
            {
                Console.Write("请输入压力(MPaA)：");
                var p = Convert.ToDouble(Console.ReadLine().Trim());
                UEwasp.P2T(p, ref t, ref r);
                Console.Write("饱和温度(℃)：" + t);
                Console.WriteLine("\n");

            }
        }
    }
}