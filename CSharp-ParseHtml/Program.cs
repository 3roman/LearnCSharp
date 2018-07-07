using System;
using Ivony.Html;
using Ivony.Html.Parser;


namespace parseHtml
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var aLinks = new JumonyParser().LoadDocument("http://www.cnblogs.com/").Find(".post_item a.titlelnk");
            foreach (var aLink in aLinks)
            {
                Console.WriteLine(aLink.InnerHtml());
            }

            Console.ReadKey();
        }

    }
}
