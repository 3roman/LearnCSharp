using System.Windows.Input;
using System.Windows;
using Nuget_PropertyChanged.Model;
using System.ComponentModel;

namespace Nuget_PropertyChanged.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public RelayCommand ShowBoxCommand { get;}
        public Student BestStudent { get; set; } = new Student() { Name = "张朝阳" };

        public MainViewModel()
        {
            ShowBoxCommand = new RelayCommand(ShowBox, CanShowBox);
        }


        private void ShowBox(object message)
        {
            MessageBox.Show(BestStudent.Name);
        }

        private bool CanShowBox(object message)
        {
            if (string.IsNullOrEmpty(BestStudent.Name))
            {
                return false;
            }

            return true;
        }


    }
}
