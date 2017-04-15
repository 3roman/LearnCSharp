using System;
using System.Collections.Generic;


namespace 字典
{
    class Program
    {
        static void Main(string[] args)
        {
            const string md5 = "e10adc3949ba59abbe56e057f20f883e";
            var rainbowTable = new Dictionary<string, string>
            {
                {"f04af61b3f332afa0ceec786a42cd365","hero"},
                {"1f3870be274f6c49b3e31a0c6728957f", "apple"},
                {"5f4dcc3b5aa765d61d8327deb882cf99", "password"},
                {"e10adc3949ba59abbe56e057f20f883e", "123456"},
                {"46f94c8de14fb36680850768ff1b7f2a", "123qwe"},
                {"2e771fe4f4354532dbc49c9c9a45e81f", "*******"}

            };

            if (rainbowTable.ContainsKey(md5))
            {
                Console.WriteLine("{0}->{1}", md5, rainbowTable[md5]);
            }

            Console.ReadKey();


        }
    }
}
