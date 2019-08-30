using System;

namespace lab_49_reference_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            // value types
            int x = 10;
            int y = x;
            y = 100;
            Console.WriteLine($"x is {x} and y is {y}");



            // reference types

            int[] array_a = new int[] { 10, 20, 30 };
            int[] array_b = array_a;

            // for every item in an array (array_name, do this)

            //  do this can be written in a LAMBDA FORM

            // LAMBDA FORM    (parameter in ==> Method out)

            //  if method is one line method then can omit { braces }

            Console.WriteLine("\n\nBefore changes\n");
            Array.ForEach(array_a, item => Console.WriteLine(item));
            Array.ForEach(array_b, item => Console.WriteLine(item));

            array_b[2] = 40;

            Console.WriteLine("\n\nAfter changes\n");
            Array.ForEach(array_a, item => Console.WriteLine(item));
            Array.ForEach(array_b, item => Console.WriteLine(item));

            var array_c = (int[])array_a.Clone();
            Array.ForEach(array_c, item => Console.WriteLine(item));
        }
    }
}
