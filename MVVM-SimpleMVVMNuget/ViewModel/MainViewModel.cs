using Mvvm;
using System.Windows.Input;
using System.Windows;
using Mvvm.Commands;

namespace WpfApp1.ViewModel
{
    class MainViewModel:BindableBase
    {
        public ICommand ShowBoxCommand { get; }
        public string Message { get; set; }

        public MainViewModel()
        {
            Message = "great mvvm pattern";
            ShowBoxCommand = new DelegateCommand(ShowBox, CanShowBox);
        }

        private void ShowBox()
        {
            MessageBox.Show(Message);
        }

        private bool CanShowBox()
        {
            if (string.IsNullOrEmpty(Message))
            {
                return false;
            }

            return true;
        }


    }
}
