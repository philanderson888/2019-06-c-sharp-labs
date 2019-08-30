using System;

namespace SnapLab_18_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog1 = new Dog(100);
            Dog dog2 = new Dog(50);
            Dog dog3 = new Dog(75);
            Console.WriteLine(dog1.CompareTo(dog2));
            Dog min;
            Dog DogMax;
            Dog DogMiddle;
            if(dog1.CompareTo(dog2) == 1)
            {
                if(dog1.CompareTo(dog3) == 1)
                {
                    DogMax = dog1;
                }
                else
                {
                    DogMiddle = dog1;
                }
            }

            Console.WriteLine(dog2.CompareTo(dog3));

        }
    }

    public class Dog : IComparable{
        public int Height { get; set; }
        public int CompareTo(Object o)
        {
            Dog d = (Dog)o;
            Console.WriteLine($"{this.Height} comparing to {d.Height}");
            if (this.Height > d.Height) return 1;
            if (this.Height == d.Height) return 0;
            return -1;

        }

        public Dog(int height)
        {
            this.Height = height;
        }

    }   

    

}
