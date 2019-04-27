using Less.Html;
using System;
using System.Net;
using System.Text;

namespace parseHtml
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // 获取百度首页所有链接
            var html = new WebClient().DownloadString("https://www.baidu.com");
            var query = HtmlParser.Query(html);
            foreach (var element in query("a"))
            {
                Console.WriteLine(element.getAttribute("href"));
            }

            Console.ReadKey();
        }

    }
}
