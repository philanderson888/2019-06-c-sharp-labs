using System;
using System.IO;
using System.Diagnostics;
using System.Threading.Tasks;

namespace lab_35_exception
{
    class Program
    {
        static void Main(string[] args)
        {


            try { }
            catch { }
            

            try {
               //    var db = new Database....
                //    db.Open()
                // exception..
            }
            catch { }
            finally {
                // this will run if exception or not eg close database
                // db.Close();
            }

            try
            {
                // potentially dodgy code here
                var data01 = File.ReadAllText("thisfiledoesnotexist.txt");

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception was thrown and caught here ");
                Console.WriteLine("Details are : ");
                //Console.WriteLine(e);
                //Console.WriteLine(e.Data);
                //Console.WriteLine(e.Message);
                Console.WriteLine("You are an amazing user and you are using this" +
                    "program beautifully");
                Console.WriteLine("We couldn't find that file you were looking for though");

                var d = DateTime.Now;
                // log exception
                File.AppendAllText("logoutput.txt",$"Exception at {d} - file not found");

                

            }
            finally { }







            Console.WriteLine("\n\nLook At Divide By Zero Exception Also\n\n");

            int x = 10;
            int y = 0;

            // throw and catch x/y please and output 'you divided by zero'

            try
            {
                int z = x / y;
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("You divided by zero");
            }

            catch(ArithmeticException ex)
            {

            }




        }
    }
}
