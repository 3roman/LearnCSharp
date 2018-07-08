using System.Windows;

namespace 没有Source的绑定
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
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public int Score { get; set; }
    }

}
