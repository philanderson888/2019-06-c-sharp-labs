using System;

namespace lab_61_events_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             
             Scenario : Child will have a birthday
                        Birthday is the EVENT
                        HaveAParty is the METHOD
                        We attach to an OOP INSTANCE ie var james = new Child();

             */
            var James = new Child();
            for (int i = 0; i < 12; i++)
            {
                James.Grow();
            }

        }
    }

    class Child
    {
        public delegate int BirthdayDelegate();    // matches HaveAParty()
        public event BirthdayDelegate OneMoreYearOlder;
        public int Age { get; set; }

        public Child()
        {
            Age = 0;
            Console.WriteLine($"Congratulations on the birth of your new baby!  Age is {Age}");
            OneMoreYearOlder += HaveAParty;   // event is now not null
        }

        public void Grow()
        {
            // call the event
            OneMoreYearOlder();
        }

        public int HaveAParty()
        {
            Age++;
            Console.WriteLine($"Celebrating Birthday : Age is now {Age}");
            return Age;
        }
    }
}
