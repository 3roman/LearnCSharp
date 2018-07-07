using MVVMDemo.ViewModels;
using MVVMDemo2.ViewModels;
using System.Windows;

namespace MVVMDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var vm = new MainWindowViewModel();
            DataContext = vm;
            datagridView1.ItemsSource = vm.Persons;

        }
    }
}
