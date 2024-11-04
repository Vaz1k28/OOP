using Lab8;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Тестування
        Car car = new Car { Model = "Toyota Camry", Year = 2023 };
        Motorcycle motorcycle = new Motorcycle();
        Truck truck = new Truck { CarryingCapacity = 10000 };

        car.Start();
        motorcycle.Drive();
        truck.Stop();

     


    }
}

public interface IVehicle
{
    void Start();
    void Stop();
    void Drive();
}

public class Car : IVehicle
{
    public string Model { get; set; }
    public int Year { get; set; }

    public void Start()
    {
        Console.WriteLine($"Автомобіль {Model} ({Year}) запущено.");
    }

    public void Stop()
    {
        Console.WriteLine("Автомобіль зупинено.");
    }

    public void Drive()
    {
        Console.WriteLine("Автомобіль їде.");
    }
}

public class Motorcycle : IVehicle
{
    public void Start()
    {
        Console.WriteLine("Мотоцикл запущено.");
    }

    public void Stop()
    {
        Console.WriteLine("Мотоцикл зупинено.");
    }

    public void Drive()
    {
        Console.WriteLine("Мотоцикл їде.");
    }
}

public class Truck : IVehicle
{
    public int CarryingCapacity { get; set; }

    public void Start()
    {
        Console.WriteLine("Вантажівка запущено.");
    }

    public void Stop()
    {
        Console.WriteLine("Вантажівка зупинено.");
    }

    public void Drive()
    {
        Console.WriteLine("Вантажівка їде.");
    }
}