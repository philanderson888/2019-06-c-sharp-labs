using System;

namespace lab_13_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            var d01 = new Dog();
            d01.Name = "Rover";
            d01.Age = 1;
            d01.Grow();
            Console.WriteLine($"The dog's age is now {d01.Age}");
            for(int i = 2; i <= 20; i++)
            {
                d01.Grow();
            }
            Console.WriteLine($"The dog's age is now {d01.Age}");
            while(d01.Age > 5)
            {
                d01.GoBackInTime();
            }
            Console.WriteLine($"The dog's age is now {d01.Age}");
        }
    }

    class Dog
    {
        public string Name;
        public int Age;

        // method
        public void Grow()
        {
            Age++;
        }
        public void GoBackInTime()
        {
            Age--;
        }
    }

}
