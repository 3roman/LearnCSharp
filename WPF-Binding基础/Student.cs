using System.ComponentModel;

namespace Binding基础
{
    public class Student : INotifyPropertyChanged
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
                if (null != PropertyChanged)
                {
                    PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Name"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
