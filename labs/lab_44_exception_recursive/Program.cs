using System;
using System.IO;

namespace lab_44_exception_recursive
{
    class Program
    {
        static void Main(string[] args)
        {
            // null reference 
           string x = null;

            try
            {
                var filecontents = File.ReadAllText("youwontfindme.txt");
                Console.WriteLine(x.Length);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine("null reference");
            }

            catch(FileNotFoundException e)
            {
                Console.WriteLine("file not found");
            }

            catch(Exception e)
            {
                Console.WriteLine("general exception");
            }
        }
    }
}
