using System;
using System.Collections.Generic;

namespace lab_16_rabbits
{
    class Program
    {
        static List<Rabbit> rabbits = new List<Rabbit>();
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nPrinting Rabbits One By One\n\n");
            for (int i =1; i<8; i++)
            {
                Console.WriteLine("Loop" + i);
                foreach (Rabbit r in rabbits)
                {
                    r.Age++;
                    Console.WriteLine($"ages are : {r.Name} is {r.Age}");
                }
                System.Threading.Thread.Sleep(200);

                var rabbit = new Rabbit(i);
                rabbits.Add(rabbit);
                // Rabbit is the CLASS (BLUEPRINT)
                // rabbit is the actual real rabbit we create from class
                // -20 means first column is 20 spaces fixed wide
                Console.WriteLine($"{rabbit.Name,-20}{rabbit.Age}");

            }
            Console.WriteLine("\n\nPrinting All Rabbits\n\n");
            foreach(var rabbit in rabbits)
            {
                Console.WriteLine($"{rabbit.Name,-20}{rabbit.Age}");
            }

        }
    }

    public class Rabbit
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Rabbit(int i)
        {
            this.Age = 0;
            this.Name = "Rabbit" + i;
        }
    }

}
