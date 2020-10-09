using PropertyChanged;

namespace WpfApp1.Model
{
    [AddINotifyPropertyChangedInterface]
    public class PT100
    {
        public int Temp { get; set; } = 30;
        public double R { get; set; }
    }
}
