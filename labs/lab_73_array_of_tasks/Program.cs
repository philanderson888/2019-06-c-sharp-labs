using System;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace lab_73_array_of_tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();
            var taskArray = new Task[3];
            taskArray[0] = Task.Run( () => {
                Thread.Sleep(100);
                Console.WriteLine($"Task 0 done at {s.ElapsedMilliseconds}");
            });
            taskArray[1] = Task.Run( () => {
                Thread.Sleep(50);
                Console.WriteLine($"Task 1 done at {s.ElapsedMilliseconds}");
            });
            taskArray[2] = Task.Run( () => {
                Thread.Sleep(25);
                Console.WriteLine($"Task 2 done at {s.ElapsedMilliseconds}");
                var taskNested = Task.Run(() => { Console.WriteLine("nested task inside task 2"); });
            });

            // WAIT FOR ONE TO TERMINATE FIRST
        //    Task.WaitAny(taskArray);

            // WAIT FOR EVERY TASK
            Task.WaitAll(taskArray);


            // hang
            Console.WriteLine($"Task terminated at {s.ElapsedMilliseconds}");
            Console.ReadLine();



            // RETURN DATA FROM A TASK

            // Generics     Task<T>    T is the TYPE of DATA TO RETURN

            var taskGiveMeDataBack = Task<string>.Run(
                () => { Console.WriteLine("task is running");
                    return "Task has completed";
                }

                );

            Console.WriteLine(taskGiveMeDataBack.Result);

        }
    }
}
