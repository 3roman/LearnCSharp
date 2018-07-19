using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WPF_ObservableCollection类的使用
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Student> students = new ObservableCollection<Student>() {
            new Student(){ Id=1, Age=11, Name="Tom"},
            new Student(){ Id=2, Age=12, Name="Darren"},
            new Student(){ Id=3, Age=13, Name="Jacky"},
            new Student(){ Id=4, Age=14, Name="Andy"}
            };

        public MainWindow()
        {
            InitializeComponent();
            lbStudent.ItemsSource = students;
            txtStudentId.SetBinding(TextBox.TextProperty, new Binding("SelectedItem.Id") { Source = lbStudent });
        }
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            students[1] = new Student() { Id = 4, Age = 14, Name = "这是一个集合改变" };
            students[2].Name = "这是一个属性改变";
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

    }
}
