using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace Binding基础
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Student _student;

        public MainWindow()
        {
            InitializeComponent();

            //_student = new Student();

            //var binding = new Binding
            //{
            //    Source = _student,
            //    Path = new PropertyPath("Name")
            //};
            //BindingOperations.SetBinding(txtName, TextBox.TextProperty, binding);

            txtName.SetBinding(TextBox.TextProperty, new Binding("Name") {Source = _student = new Student()});

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _student.Name += "Click ";
        }
    }
}
