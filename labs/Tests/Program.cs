using System;
using System.Collections.Generic;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }

    public class Eng35Tests
    {
        // Pass in a sentence and return an array of individual words
        public static string[] Create_Array_From_Sentence(string sentence)
        {
            return new string[] { };
        }

        // Pass in a sentence and return the number of words
        public static int Calculate_Words_In_Sentence(string sentence)
        {
            return -1;
        }

        public static string Turn_First_Word_To_Uppercase(string sentence)
        {
            // "this is a sentence" returns "THIS is a sentence"
            return "";
        }

        public static string Turn_All_Words_To_Uppercase_But_Last_Word_To_Lowercase(string sentence)
        {
            // "this is a sentence" returns "THIS IS A sentence"
            return "";
        }

        /*
         *Coding Task

            Pass in array of 10 numbers   [10,11,15,25..

            While loop ==> add one to each number  [11,12,16

               int counter = 0;
               while(counter < myArray.Length){
                  myArray[counter] = myArray[counter]+1; 
                  counter++;
            }

            Do..While loop ==> add 3 to each number  [14,15,19..

            Foreach loop ==> double each number  [28,30,38...

                  counter = 0;
                  foreach (var item in myArray){
                    
                        // do stuff here with myArray[counter]
                        counter++;
                  }

            Create a Cat class with string Name and int Age.   Have a Constructor.

            Create a list of Cats and foreach loop => create new cat with name 'Cat'+number' and Age=number
                            eg first cat is called 'Cat28' and has Age 28.

            Print the list of cats with names and ages

            Return the total of all the ages of all cats!

        
         * */

        static List<Cat> cats = new List<Cat>();

        public static int Mega_Multiple_Coding_Loops(int[] myArray)
        {

        int counter = 0;
            while (counter < myArray.Length)
            {
                myArray[counter]++;
                counter++;
            }

            counter = 0;
            do
            {
                myArray[counter] += 3;
                counter++;
            }
            while (counter < myArray.Length);

            counter = 0;
            foreach(var item in myArray)
            {
                myArray[counter] *= 2;
                var c = new Cat("Cat" + item.ToString(), item);
                cats.Add(c);
                counter++;
            }

            int totalAge = 0;
            foreach(var cat in cats)
            {
                totalAge += cat.Age;
                Console.WriteLine($"Name{cat.Name,-20}{cat.Age,-10}");
            }


            return totalAge;
        }

        public static int Mega_Multiple_Coding_Loops2(int[] myArray) {
            return -1;
            // stopwatch and rebuild
        }

        public static int How_Many_Numbers_Divisible_By(int start, int end, int divisor)
        {
            // how many integers are divisible by given divisor in the given range?
            // example (2,10,4) means start at 2 and count up to 10
            // only 4 and 8 are divisible by 4
            // so answer is 2

            return -1;
        }

        public static int Array_Loop_Queue_Stack(int[] array)
        {
            // 145     49 toby 49 therese  49 liam  51 sanru 
            return -1;
        }


    }

    public class Cat
    {
        private int _hideme;
        public string Name { get; set; }
        public int Age { get; set; }

        public Cat(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }

    }
}
