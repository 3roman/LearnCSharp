using Mvvm;
using System.Windows.Input;
using System.Windows;
using Mvvm.Commands;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    class MainViewModel : BindableBase
    {
        public ICommand ShowBoxCommand { get; }
        public Student student { get; set; } = new Student() { Name = "张朝阳" };

        public MainViewModel()
        {
            ShowBoxCommand = new DelegateCommand(ShowBox, CanShowBox);
        }

        private void ShowBox()
        {
            MessageBox.Show(student.Name);
        }

        private bool CanShowBox()
        {
            if (string.IsNullOrEmpty(student.Name))
            {
                return false;
            }

            return true;
        }


    }
}
