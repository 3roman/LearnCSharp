using System;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {

            var calculator1 = Factory.MakeCalculator("+");
            Console.WriteLine(calculator1.Compute(10, 5));

            var calculator2 = Factory.MakeCalculator("-");
            Console.WriteLine(calculator2.Compute(10, 5));

            var calculator3 = Factory.MakeCalculator("*");
            Console.WriteLine(calculator3.Compute(10, 5));

            var calculator4 = Factory.MakeCalculator("/");
            Console.WriteLine(calculator4.Compute(10, 5));

            Console.ReadKey();

        }
    }

    #region 工厂类
    public class Factory
    {
        public static Calculator MakeCalculator(string operate)
        {
            Calculator calculator = null;
            switch (operate)
            {
                case "+":
                    calculator = new Add();
                    break;
                case "-":
                    calculator = new Subtract();
                    break;
                case "*":
                    calculator = new Multiply();
                    break;
                case "/":
                    calculator = new Divide();
                    break;
            }

            return calculator;
        }
    }
    #endregion


    #region 运算类
    public class Calculator
    {
        public virtual int Compute(int x, int y)
        {
            return 0;
        }
    }

    class Add : Calculator
    {
        public override int Compute(int x, int y)
        {
            return x + y;
        }
    }

    class Subtract : Calculator
    {
        public override int Compute(int x, int y)
        {
            return x - y;
        }
    }

    class Multiply : Calculator
    {
        public override int Compute(int x, int y)
        {
            return x * y;
        }
    }

    class Divide : Calculator
    {
        public override int Compute(int x, int y)
        {
            if (0 == y)
            {
                return 0;
            }

            return x / y;
        }
    }
    #endregion

}
