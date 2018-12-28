using System;

namespace CSharp_Event
{
    class Program
    {
        static void Main(string[] args)
        {
            TestEvent te = new TestEvent();
            te.RaiseValueChanged(null, null);
        }
    }


    class TestEvent
    {
        // 定义事件
        public event EventHandler ValueChanged;

        // 响应函数
        private void OnValueChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Value Changed");
        }

        // 事件绑定
        public TestEvent()
        {
            ValueChanged += OnValueChanged;
        }

        // 触发事件
        public void RaiseValueChanged(object sender, EventArgs e)
        {
            ValueChanged?.Invoke(sender, e);
        }
    }
}
