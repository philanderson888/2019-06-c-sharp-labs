using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from Phil!");
            int x = default;
            Console.WriteLine(x);
            string y = default;
            Console.WriteLine(y);
            Console.WriteLine(y==null);
            Console.WriteLine(y=="");
            int number = 2;
            switch (number)
            {
                case 1:
                    break;
                case 2:
                case 3:
                    Console.WriteLine("cases 2&3");
                    break;
                case int n when (n >= 4 && n <= 10):
                    Console.WriteLine("between 4 and 10");
                    break;
                default:
                    break;
            }
            var myString = "\"hello\"";
            Console.WriteLine(myString);


            var f = 1.23F;
            Console.WriteLine(f);
            var f02 = 1.4567456745674567456745674567;
            Console.WriteLine(f02);

            // use with exponential numbers ie 10^20
            Console.WriteLine(double.MinValue);
            Console.WriteLine(double.MaxValue);

            Console.WriteLine(float.MinValue);
            Console.WriteLine(float.MaxValue);

            // highest degree of precision in calculations (eg money)
            Console.WriteLine(decimal.MinValue);
            Console.WriteLine(decimal.MaxValue);


            // Care when equating double numbers
            var d01 = 0.1;
            var d02 = 0.2;
            Console.WriteLine(d01+d02 == 0.3);

            // Care when equating double numbers
            var d03 = 0.1M;
            var d04 = 0.2M;
            Console.WriteLine(d03 + d04 == 0.3M);

            // test less than small number
            Console.WriteLine((d01+d02-0.3)<0.00000001);


            Console.ReadLine();
        }
    }
}
