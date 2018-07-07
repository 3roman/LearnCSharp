using MVVMDemo.Commands;
using System.Windows;

namespace MVVMDemo.ViewModels
{
    class MainWindowViewModel:NotificationObject
    {
        private int _input1;

        public int Input1
        {
            get { return _input1; }
            set {
                _input1 = value;
                RaisePropertyChanged("Input1");
            }
        }

        private int _input2;

        public int Input2
        {
            get { return _input2; }
            set
            {
                _input2 = value;
                RaisePropertyChanged("Input2");
            }
        }

        private int _result;

        public int Result
        {
            get { return _result; }
            set
            {
                _result = value;
                RaisePropertyChanged("Result");
            }
        }

        public DelegateCommand AddCommand { get; set; }

        private void Add(object parameter)
        {
            Result = Input1 + Input2;
        }

        private bool CheckInput(object parameter)
        {
            if (Input1 < 0)
            {
                MessageBox.Show("Input must greater than zero");
                return false;
            }
            return true;
        }

        public DelegateCommand HelpCommand { get; set; }

        private void Help(object parameter)
        {
            MessageBox.Show("hello MVVM");
        }

        public MainWindowViewModel()
        {
            AddCommand = new DelegateCommand();
            AddCommand.ExecuteAction += Add;
            AddCommand.CanExecuteFunc += CheckInput;

            HelpCommand = new DelegateCommand();
            HelpCommand.ExecuteAction += Help;
        }

    }
}
