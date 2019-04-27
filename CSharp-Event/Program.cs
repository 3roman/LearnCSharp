using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharp_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            var heater = new Heater();
            // 订阅温升事件
            heater.OnHeating += new Displayer().Display;
            // 订阅水开事件
            heater.OnBoiled += new Alarmer().Alarm;
            heater.PowerOn();

            Console.ReadKey();
        }
    }

    class Heater
    {
        // 沸腾事件
        public event Action<object, HeaterEventArgs> OnBoiled;
        // 加热事件
        public event Action<object, HeaterEventArgs> OnHeating;
        // 初始水温20℃
        private int CurrentTemperature = 20;

        public void PowerOn()
        {
            while (true)
            {
                // 水温每隔100ms升1度
                Thread.Sleep(100);
                CurrentTemperature++;
                // 每改变1度触发一次事件
                OnHeating?.Invoke(this, new HeaterEventArgs(CurrentTemperature));

                // 超过100度停止加热，触发水开事件
                if (CurrentTemperature == 100)
                {
                    OnBoiled?.Invoke(this, null);
                    break;
                }
            }
        }

        public class HeaterEventArgs : EventArgs
        {
            public int CurrentTemperature { get; set; }
            public HeaterEventArgs(int t)
            {
                CurrentTemperature = t;
            }
        }
    }

    class Displayer
    {
        public void Display(object sender, Heater.HeaterEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"当前水温：" + e.CurrentTemperature);
        }
    }

    class Alarmer
    {
        public void Alarm(object sender, Heater.HeaterEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("水开了，自动断电!!!");
        }
    }
}
