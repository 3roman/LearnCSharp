using System;
using System.Windows.Input;

namespace WPF_触发器
{
    class DelegateCommand : ICommand

    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            if (null == CanExecuteFunc)
            {
                return true;
            }

           return CanExecuteFunc(parameter);
        }

        public void Execute(object parameter)
        {
            if (null == ExecuteAction)
            {
                return;
            }

            ExecuteAction(parameter);
        }

        public Func<object, bool> CanExecuteFunc { get; set; }
        public Action<object> ExecuteAction { get; set; }
        

    }
}
