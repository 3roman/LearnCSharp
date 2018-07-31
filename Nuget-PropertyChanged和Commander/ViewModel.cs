using Commander;
using System;
using PropertyChanged;
using System.Threading.Tasks;

namespace Nuget_PropertyChanged和Commander
{
    [ImplementPropertyChanged]
    class ViewModel 
    {
        public string CurrentTime { get; set; }

        [OnCommand("TickTickCommand")]
        public void TickTick()
        {
            Task.Run(async()=>
            {
                while (true)
                {
                    CurrentTime = DateTime.Now.ToLongTimeString().ToString();
                    await Task.Delay(1000);
                }
            }
                );
        }

        [OnCommandCanExecute("TickTickCanExecute")]
        public bool TickTickCanExecute()
        {
            // TODO
            return true;
        }
    }
}
