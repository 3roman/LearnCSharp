using System.Windows;
using MVVMDemo.View;
using MVVMDemo.ViewModel;

namespace MVVMDemo
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var window = new WindowMain();
            window.DataContext = new VMWindowMain();
            window.Show();

            base.OnStartup(e);
        }
    }
}
