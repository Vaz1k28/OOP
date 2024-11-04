using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace Успадкування
    {
        class Фігура
        {
            public virtual double CalculateArea()
            {
                return 0;
            }

            public virtual double CalculatePerimeter()
            {
                return 0; 
            }
        }

        class Коло : Фігура
        {
            public double Radius { get; set; }

            public override double CalculateArea()
            {
                return 3.14 * Radius * Radius;
            }

            public override double CalculatePerimeter()
            {
                return 2 * 3.14 * Radius;
            }
        }

        class Прямокутник : Фігура
        {
            public double Width { get; set; }
            public double Height { get; set; }

            public override double CalculateArea()
            {
                return Width * Height;
            }

            public override double CalculatePerimeter()
            {
                return 2 * (Width + Height);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                
                Коло a = new Коло { Radius = 5 };
                Прямокутник b = new Прямокутник { Width = 4, Height = 6 };

                
                Console.WriteLine($"Площа кола: {a.CalculateArea()}");
                Console.WriteLine($"Периметр кола: {a.CalculatePerimeter()}");

                Console.WriteLine($"Площа прямокутника: {b.CalculateArea()}");
                Console.WriteLine($"Периметр прямокутника: {b.CalculatePerimeter()}");
            }
        }
    }