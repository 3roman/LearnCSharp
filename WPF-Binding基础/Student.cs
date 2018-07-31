using System.ComponentModel;

namespace Binding基础
{
    public class Student : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value == _name)
                {
                    return;
                }

                _name = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Name"));
            }

        }

    }
}
