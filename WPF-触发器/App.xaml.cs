
using System.Windows;

namespace WPF_触发器
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {

            var wnd = new MainWindow();
            wnd.DataContext = new MainWindowViewModel();
            wnd.Show();
            base.OnStartup(e);


        }
    }
}
