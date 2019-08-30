using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace lab_72_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            // OLD
            var ActionMethod01 = new Action(DoThis);
            var task01 = new Task(ActionMethod01);
            task01.Start();

            // OLD
            // HEY COMPUTER PLEASE CREATE A BACKGROUND TASK, AND, WHENEVER THE CPU HAS RESOURCES AVAILABLE, RUN THIS TASK. PLEASE.  THANKS!
            // CPU : HEY, NO PROBLEM.  
            

            var task02 = Task.Factory.StartNew(
                        // PLACEHOLDER FOR A METHOD
                        // DELEGATES WHICH ARE PLACEHOLDERS FOR METHOD
                       () => { Console.WriteLine("Inside Task02 which is called by Task Factory"); }
                );

            // ALMOST CURRENT
            var task03 = new Task(
                () => { Console.WriteLine("In task 03"); }
                );
            task03.Start();

            // DO THIS WAY
            var task04 = Task.Run(
                () => {
                    Console.WriteLine("In task 04 - use this way to create and run tasks" );
                    DoThis();
                }
            );

            // hang the program so it does not terminate
            Console.WriteLine("The program has finished");
            Console.ReadLine();
        }

        static void DoThis()
        {
            Thread.Sleep(10);
            Console.WriteLine("I am doing something");
        }
    }
}
