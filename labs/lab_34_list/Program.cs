using System;
using System.Collections.Generic;
using System.Collections;

namespace lab_34_list
{
    class Program
    {

        static List<int> list01 = new List<int>();
        static List<string> list02 = new List<string>();

        static void Main(string[] args)
        {
            // arrays are fixed
            var array01 = new int[10];  // size fixed
            // 2d array
            int[,] Grid2D = new int[10, 10];
            int[,,] Cube3D = new int[5, 5, 5];
            var Grid4D = new int[10, 10, 10, 10];
            // the above arrays are all fixed in size 100% 

            // it's possible to create an array of arrays where each array can be
            // different size

            // jagged array
            int[][] jaggedArray01 = new int[3][];
            // first array size 10
            jaggedArray01[0] = new int[10];
            // seconde array size 100
            jaggedArray01[1] = new int[100];
            jaggedArray01[2] = new int[1000];

            // private scope inside method
            List<short> shortList = new List<short>();


            list01.Add(10);  // index 0
            list01.Add(20);  // index 1
            list01.Insert(0, 100);  // index 0, push others along

            foreach(var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            list01.RemoveAt(0);
            Console.WriteLine("\n\nRemove index 0\n");
            foreach (var item in list01)
            {
                Console.WriteLine($"{item}");
            }

            // list of strings x 3
            // insert new item at index 1 and view result

            list02.Add("fee");
            list02.Add("fo");
            list02.Add("fum");

            list02.Insert(1, "fi");

            foreach(var name in list02)
            {
                Console.WriteLine(name);
            }

            // FOREACH BLOCK : USE QUITE OFTEN


            Console.WriteLine("\n\nDictionary\n\n");
            var dictionary01 = new Dictionary<int, string>();
            var dictionary02 = new Dictionary<int, int>();
            var dictionary03 = new Dictionary<string, int>();

            dictionary01.Add(10, "hi");
            dictionary01.Add(20, "there");
            dictionary01.Add(30, "spartans");
            dictionary01.Add(40, "spartans2");
            dictionary01.TryAdd(40, "some value");
            dictionary02.TryAdd(40, 40);
            dictionary03.TryAdd("this is a key", 40);


            // ITERATE ==> LOOP OVER DICTIONARY
            foreach(var key in dictionary01.Keys)
            {
                Console.WriteLine($"Key {key,-15} Value {dictionary01[key]}");
            }

            // queue
            var queue = new Queue<int>();
            queue.Enqueue(10); // add first item
            queue.Enqueue(20);  // second
            queue.Enqueue(30);  // third

            //.....................................30......20.....10....BUS STOP

            var itemWhichJustGotOnTheBus = queue.Dequeue();  // first item get on bus

            //.....................................30......20......BUS STOP      

            Console.WriteLine($"item which just got on bus is {itemWhichJustGotOnTheBus}");

            Console.WriteLine($"Queue contains number 50? {queue.Contains(50)}");
            Console.WriteLine($"Queue contains number 20? {queue.Contains(20)}");

            Console.WriteLine($"Check out who is first in line {queue.Peek()}");

            // iterate  ==> print a foreach loop    


            // stack
            Console.WriteLine("\n\nStack");
            var stack = new Stack<string>();

            stack.Push("first");
            stack.Push("second");
            stack.Push("third");
            stack.Push("fourth");  // LIFO : last to arrive

            foreach (var item in stack) { Console.WriteLine(item); }

            Console.WriteLine("\nRemove one item 'pop' off top");
            stack.Pop();

            foreach (var item in stack) { Console.WriteLine(item); }

            // contains
            // peek


            // snap code till lunch
            // take numbers as an array 10 20 30 40
            int[] array = new int[] { 10, 20, 30, 40 };
            // create a list, multiply by 10       100 200 300 400
            var list = new List<int>();
            foreach(var item in array) { list.Add(item*10); }
            // create a queue, add 1               401   301   201  101 ===>
            var queue01 = new Queue<int>();
            foreach(int i in list) {
                queue01.Enqueue(i + 1);
            }
            var stack01 = new Stack<int>();
            // create a stack, add 2   
            while (queue01.Count > 0)
            {
                stack01.Push(queue01.Dequeue() + 2);
            }
            var total = 0;
            foreach(var item in stack01)
            {
                total += item;
            }
            // what's the sum?
            Console.WriteLine(total);  // 1012


            Console.WriteLine("\n\nArrayList\n\n");
            var objectList = new ArrayList();
            objectList.AddRange(new int[] { 10, 20, 30, 40, 50 });
            objectList.Add("hi there");
            objectList.Add(true);
            objectList.Add(DateTime.Now);

            foreach(var item in objectList)
            {
                Console.WriteLine($"{item.GetType(),-20}{item}");
            }

            


    
            


        }

        void DoThis() {
            list01.Add(10);
            list02.Add("hi");
            // shortList invisible
        }
        void DoThat() { }
    }
}
