using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EmbedWin32Dll
{
    class Program
    {
        static void Main(string[] args)
        {
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
