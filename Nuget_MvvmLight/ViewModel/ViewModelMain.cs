using System.Windows;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using WpfApp2.Model;

namespace WpfApp2.ViewModel
{
    internal class ViewModelMain:ViewModelBase
    {
        public Student Stu { get; set; }
        public RelayCommand ShowCommand { get;}

        public ViewModelMain()
        {
            Stu = new Student{Name = "小明"};
            ShowCommand = new RelayCommand(Show, CanShow);
        }

        private void Show()
        {
            MessageBox.Show(Stu.Name);
        }

        private bool CanShow()
        {
            return !string.IsNullOrEmpty(Stu.Name);
        }
    }
}
