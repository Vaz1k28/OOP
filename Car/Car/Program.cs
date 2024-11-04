using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car("F90", "write", 100);
            Car car3 = new Car("1", "black", 50);
            Console.WriteLine(car1.PrintInfo());
            Console.WriteLine(car2.PrintInfo());
            Console.WriteLine(car3.PrintInfo());
            Console.WriteLine(car2.ChangePrice(10));
            Console.WriteLine(car2.ChangeColor("blacr"));

        }
    }
}
class Car
{
    public string Name;
    public string Color;
    public double Price;
    public const string CompanyName = "BMW";
    public Car()
    {
        this.Name = "";
        this.Color = "";
        this.Price = 0;
    }
    public Car(string Name, string Color, double Prise)
    {
        this.Name = Name;
        this.Color = Color;
        this.Price = Prise;
    }
    public void input()
    {
        Console.WriteLine("Введіть назву машини");
        Name = Console.ReadLine();
        Console.WriteLine("Введіть колір машини");
        Color = Console.ReadLine();
        Console.WriteLine("Введіть ціну машини");
        Price = double.Parse(Console.ReadLine());
    }
    public void Print()
    {
        Console.WriteLine($"Car name:{Name}");
        Console.WriteLine($"Color:{Color}");
        Console.WriteLine($"Price:{Price}");
        Console.WriteLine($"CompanyName:{CompanyName}");
    }
    public double ChangePrice(double x)
    {
        return this.Price -= Price * (x / 100);
    }
    public string ChangeColor(string newColor)
    {
        Color = newColor; 
        return $"Car color changed to: {newColor}";
    }
        public string PrintInfo()
    {
        return $"Car name:{Name},Color:{Color},Price:{Price},CompanyName:{CompanyName}";
    }
}