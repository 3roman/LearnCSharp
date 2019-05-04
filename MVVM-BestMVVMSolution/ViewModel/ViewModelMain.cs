using MVVM_BestMVVMSolution.Model;
using System.Windows;
using System.ComponentModel;

namespace MVVM_BestMVVMSolution.ViewModel
{
    class ViewModelMain : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Student Stu { get; set; } = new Student { Name = "Tom" };
        public RelayCommand TestCommand { get; }

        public ViewModelMain()
        {
            TestCommand = new RelayCommand(Test, CanTest);
        }

        private void Test(object parameter)
        {
            MessageBox.Show(Stu.Name);
        }

        private bool CanTest(object parameter)
        {
            if (string.IsNullOrEmpty(Stu.Name))
            {
                return false;
            }
            return true;
        }

    }
}
