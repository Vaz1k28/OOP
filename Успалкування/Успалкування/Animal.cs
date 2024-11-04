using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Animal
    {
        public float Weight { get; set; }
        public string Color { get; set; }

        public Animal(string color, float weight)
        {
            Color = color;
            Weight = weight;
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return $"This is an Animal, Color = {Color}, Weight = {Weight}";
        }
    }

    internal abstract class AnimalWithTail : Animal
    {
        public float TailLength { get; set; }

        public AnimalWithTail(string color, float weight, float tailLength)
            : base(color, weight)
        {
            TailLength = tailLength;
        }

        public override string MakeSound()
        {
            return "Generic animal sound";
        }

        public override string ToString()
        {
            return base.ToString() + $", TailLength = {TailLength}";
        }
    }

    internal class Cat : AnimalWithTail
    {
        public Cat(string color, float weight, float tailLength)
            : base(color, weight, tailLength)
        {
        }

        public override string MakeSound()
        {
            return "Meow";
        }

        private string Purr()
        {
            return "purrrrrrrr";
        }

        public override string ToString()
        {
            return $"This is a Cat, {base.ToString()}";
        }


        public class Dog : AnimalWithTail
        {
            public Dog(string color, float weight, float tailLength)
                : base(color, weight, tailLength)
            {
            }

            public override string MakeSound()
            {
                return "Woof!";
            }

            public override string ToString()
            {
                return $"This is a Dog, {base.ToString()}";
            }
        }
    }
}