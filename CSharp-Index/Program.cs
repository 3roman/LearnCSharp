namespace CSharp_Index
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Student();
            s[0] = "小明";
            s[1] = "丽丽";

            for (int i = 0; i < 2; i++)
            {
                System.Console.WriteLine(s[i]);
            }

            System.Console.Read();
        }
    }


    class Student
    {
        private string[] names = new string[100];

        // 声明索引器
        public string this[int index]
        {
            get { return names[index]; }
            set { names[index] = value; }
        }
    }
}
