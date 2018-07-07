using MVVMDemo.Commands;
using MVVMDemo.ViewModels;
using MVVMDemo2.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MVVMDemo2.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Person> _persons;

        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
        }

        public MainWindowViewModel()
        {
            _persons = new ObservableCollection<Person>
            {
                new Person{ Name = "lucy", Age = 25 },
                new Person{ Name = "tom", Age = 18 }
            };
        }

        private RelayCommand _addPersonCommand;
        public ICommand AddPersonCommand
        {
            get
            {
                if (null == _addPersonCommand)
                {
                    _addPersonCommand = new RelayCommand(x => AddPerson());
                }

                return _addPersonCommand;
            }
        }

        private void AddPerson()
        {
            _persons.Add(new Person { Name = "lim", Age = 31 });
        }




    }

}
