using _07_NullableEnumStruct.Enums;
using _07_NullableEnumStruct.Models;
using System;

public class Program
{
    static void Main()
    {
        var order1 = new DrinkOrder(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
        order1.DisplayOrder();

        order1.UpdateStatus(OrderStatus.Preparing);
        order1.UpdateStatus(OrderStatus.Ready);
        order1.UpdateStatus(OrderStatus.Delivered);

        var order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);

        var order3 = new DrinkOrder(103, "Vuqar", DrinkType.Juice, DrinkSize.Small);
        order2.DisplayOrder();
        order2.UpdateStatus(OrderStatus.Ready);

        Console.WriteLine("DrinkType");
        foreach (var item in Enum.GetValues(typeof(DrinkType)))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("DrinkSize");
        foreach (var item in Enum.GetValues(typeof(DrinkSize)))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("OrderStatus");
        foreach (var item in Enum.GetValues(typeof(OrderStatus)))
        {
            Console.WriteLine(item);
        }

        Console.WriteLine(DrinkType.Coffee.ToString());
        Console.WriteLine(DrinkSize.Large.ToString());

        DrinkType parsedDrink = (DrinkType)Enum.Parse(typeof(DrinkType), "Tea");
        DrinkSize parsedSize = (DrinkSize)Enum.Parse(typeof(DrinkSize), "Medium");

        Console.WriteLine(parsedDrink);
        Console.WriteLine(parsedSize);

        Console.WriteLine($"1-ci sifaris qiymeti: {order1.Price}");
        Console.WriteLine($"2-ci sifaris qiymeti: {order2.Price}");
        Console.WriteLine($"3-ci sifaris qiymeti: {order3.Price}");

        decimal total = order1.Price + order2.Price + order3.Price;
        Console.WriteLine($"Total Cost: {total}");


    }
}
