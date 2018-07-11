using SQLite;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace 控件DataGrid
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public SQLiteConnection Conn { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Conn = new SQLiteConnection("test.db");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Persons = Conn.Table<Person>().ToList();
            datagrid1.ItemsSource = Persons;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Conn.Execute("")
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var email = txtEmail.Text;
            var married = (bool)chkMarried.IsChecked;
            Conn.Insert(new Person()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Married = married
            });

        }
            
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var id = txtId.Text;
            var firstName = txtFirstName.Text;
            var lastName = txtLastName.Text;
            var email = txtEmail.Text;
            var married = (bool)chkMarried.IsChecked;

            string sql = string.Format("UPDATE Person SET FirstName = '{0}', LastName='{1}', Email='{2}', Married={3} WHERE ID = {4}",
                firstName,
                lastName,
                email,
                married,
                id); 
            Conn.Execute(sql);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var id = txtId.Text;
            string sql = string.Format("DELETE FROM Person WHERE ID = {0}", id);
            Conn.Execute(sql);
        }


        // 实体类名必须与数据库中表名一致
        public class Person
        {
            [PrimaryKey, AutoIncrement]
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public bool Married { get; set; }
        }
    }
}
