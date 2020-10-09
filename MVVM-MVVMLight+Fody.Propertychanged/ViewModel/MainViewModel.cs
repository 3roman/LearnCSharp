using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PropertyChanged;
using System.Windows;
using WpfApp1.Model;


namespace WpfApp1.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainViewModel : ViewModelBase
    {
        public PT100 Sensor { get; set; }  = new PT100();
        public RelayCommand ShowTemp => new RelayCommand(_ShowTemp);

        private void _ShowTemp()
        {
            MessageBox.Show($"当前温度为{Sensor.Temp}℃");
        }
    }
}