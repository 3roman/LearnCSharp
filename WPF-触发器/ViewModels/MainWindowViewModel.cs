using System.Windows;

namespace WPF_触发器
{
    class MainWindowViewModel
    {
        
        public DelegateCommand FooCommand { get; set; }

        private void Foo(object parameter)
        {
            MessageBox.Show("hello EventTrigger");
        }

        public MainWindowViewModel()
        {
            FooCommand = new DelegateCommand();
            FooCommand.ExecuteAction += Foo;
        }

    }
}
