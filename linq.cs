using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LINQ
{
    public enum Gender{ 男, 女, 人妖};

    public class Roster
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public int Age { get; set; }
        public Gender Sex { get; set; }
        public bool Married { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var roster = new List<Roster>
            {
                new Roster{Id=0, Name= "杨飞", Age=20, Sex =Gender.男, Married= true},
                new Roster{Id=1, Name= "李琼", Age=25, Sex = Gender.女, Married=true},
                new Roster{Id=2, Name= "刘沫", Age=33, Sex = Gender.女, Married=false},
                new Roster{Id=3, Name= "吴敏", Age=18, Sex = Gender.女, Married=false},
                new Roster{Id=4, Name= "夏明", Age=18, Sex = Gender.男, Married=false},
                new Roster{Id=5, Name= "张晓梅", Age=22, Sex = Gender.女, Married=true},
                new Roster{Id=6, Name= "吴昊", Age=36, Sex = Gender.男, Married=false},
                new Roster{Id=7, Name= "朱秀梅", Age=31, Sex = Gender.女, Married=true},
                new Roster{Id=8, Name= "尤花", Age=29, Sex = Gender.女, Married=true},
                new Roster{Id=9, Name= "韩勇", Age=28, Sex = Gender.男, Married=false},
                new Roster{Id=10, Name= "余攀", Age=30, Sex = Gender.男, Married=true}
            };

            var ret = roster.
                Where(x => x.Married && x.Sex==Gender.女).
                OrderBy(x => x.Id).
                Select(x => new {x.Id, x.Name}).
                ToList();

            ret.ToList().ForEach(Console.WriteLine);

            var files =
                    from filename in Directory.GetFiles("c:/windows/system32")
                    let fileinfo = new FileInfo(filename)
                    where fileinfo.Extension.Contains("exe")
                    orderby fileinfo.Length, fileinfo.Name
                    select new {fileinfo.Name, fileinfo.FullName};
            files.ToList().ForEach(Console.WriteLine);

            var haha =
                from filename in Directory.GetFiles("c:/windows/system32")
                let fileinfo = new FileInfo(filename)
                group fileinfo by fileinfo.Extension
                into groups
                from item in groups
                orderby item.Extension
                select new {item.FullName};

            haha.ToList().ForEach(Console.WriteLine);



            Console.ReadLine();


        }
    }
}
