using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Успалкування
{
    class Фрукт
    {
        public virtual string Name { get; set; }
        public Фрукт(string name)
        {
            Name = name;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Назва фрукта: {Name}");
        }
    }
    class Яблуко : Фрукт
    {
        public string Variety { get; set; }

        public string Color { get; set; }

        public Яблуко(string name, string variety, string color) : base(name)
        {
            Variety = variety;
            Color = color;
        }
        public void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Сорт: {Variety}");
            Console.WriteLine($"Колір: {Color}");
        }
    }


    class Груша : Фрукт
    {
    public string Variety { get; set; }

    public string Color { get; set; }

    public Груша(string name, string variety, string color) : base(name)
    {
        Variety = variety;
        Color = color;
    }
        public void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine($"Сорт: {Variety}");
        Console.WriteLine($"Колір: {Color}");
    }
        class Program
        {
            static void Main(string[] args)
            {
                Фрукт груша = new Фрукт("Груша");

        
                Яблуко симіренко = new Яблуко("Симиренко", "Зимовий", "Зелено-жовтий");

               
                груша.PrintInfo();
                Console.WriteLine();
                симіренко.PrintInfo();
            }
        }
    }


}
