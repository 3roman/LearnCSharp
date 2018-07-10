using SQLite;
using System;
using System.Linq;
using System.Windows;

namespace 控件ListView
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var conn = new SQLiteConnection("test.db");
            var Persons = conn.Table<Person>().ToList();
            listView1.ItemsSource = Persons;

        }
    }

  
    // 实体类名必须与数据库中表名一致
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public Int64 Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}
