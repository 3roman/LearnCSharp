using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Console.WriteLine("hello world");
        var sc = new ShopCart();
        sc.AddFruits(new Apple());
        sc.AddFruits(new Orange());
        Console.WriteLine("totalPrice = {0}", sc.GetTotalPrice());
    }

}

// 接口是一种只包含虚函数的类
interface IFruit
{
    double GetPrice();
}


class Apple : IFruit
{
    public double GetPrice()
    {
        return 5.0;
    }
}


class Orange : IFruit
{
    public double GetPrice()
    {
        return 10.0;
    }
}


class ShopCart
{
    private List<IFruit> fruits = new List<IFruit>();

    public void AddFruits(IFruit fruit)
    {
        fruits.Add(fruit);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        fruits.ForEach(x => totalPrice += x.GetPrice());

        return totalPrice;
    }
}
