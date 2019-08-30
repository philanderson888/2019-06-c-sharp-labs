using System;

namespace lab_60_events_trivial
{
    class Program
    {
        // delegate (restriction on method types)
        public delegate int Delegate01(string x);
        // event
        public static event Delegate01 Event01;
        static void Main(string[] args)
        {
 
        }


        static int Method01(string input)
        {
            Console.WriteLine("hey are you printing something?");
            Console.WriteLine(input);
            return input.Length;
        }
        static int Method02(string input)
        {
            Console.WriteLine("hey are you 2 printing something?");
            Console.WriteLine(input);
            return input.Length;
        }
    }
}
