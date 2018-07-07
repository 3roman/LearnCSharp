using System.Collections.ObjectModel;
using System.Windows;

namespace 集合对象作为Binding源
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var students =  new ObservableCollection<Student>()
            {
                new Student() {Name = "张三", Age = 25, Score = 95},
                new Student() {Name = "杨三娘", Age = 30, Score = 97},
                new Student(){Name = "李四", Age = 32, Score = 80},
                new Student(){Name = "王二", Age = 30, Score = 99}
            };

            LvMain.ItemsSource = students;
        }
    }
}
