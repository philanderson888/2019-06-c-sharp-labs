using System;
using System.Collections;
using System.Collections.Generic;

namespace SnapLab_02_5_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 
             * 
                Snap Lab : 10 minutes
                Input 5 numbers and put into an ArrayList
                Create an Array, List, Queue, Stack, Dictionary.
                Move objects from Arraylist to each item and multiply by 4 each move.
                What's the total?
            
                // Follow up : write a test to input 5 integers and output the answer
             * 
             * 
             * */

            var arraylist = new ArrayList();
            var list = new List<int>();
            var array = new int[5];
            var queue = new Queue<int>();
            var stack = new Stack<int>();
            var dict = new Dictionary<int, int>();
            arraylist.Add(5);
            arraylist.Add(6);
            arraylist.Add(7);
            arraylist.Add(8);
            arraylist.Add(9);
            var counter = 0;
            foreach(var o in arraylist)
            {
                array[counter] = (int)o * 4;
                counter++;
            }

            foreach(var item in array)
            {
                list.Add(item * 4);
            }
            foreach (var item in list)
            {
                queue.Enqueue(item * 4);
            }
            while (queue.Count>0)
            {
                stack.Push(queue.Dequeue() * 4);
            }
            counter = 0;
            while(stack.Count>0)
            {
                dict.Add(counter, stack.Pop() * 4);
                counter++;
            }
            int total = 0;
            foreach(var key in dict.Keys)
            {
                total += dict[key];
            }
            Console.WriteLine(total);

        }
    }
}
