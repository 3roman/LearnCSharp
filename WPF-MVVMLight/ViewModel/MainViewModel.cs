using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;
using System.Windows;

namespace WPF_MVVMLight.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public int X { get; set; } = 1;
        public int Y { get; set; } = 2;
        private int z;

        public int Z
        {
            get { return z; }
            set { Set(ref z, value); }
        }


        public ICommand AddCommand { get; set; }
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            Z = X + Y;
            AddCommand = new RelayCommand(Add);
        }

        public void Add()
        {
            //MessageBox.Show("Test");
            Z = X + Y;
        }
    }
}