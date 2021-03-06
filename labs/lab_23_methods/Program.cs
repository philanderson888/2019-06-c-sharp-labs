﻿using System;

namespace lab_23_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            #region codeblock1
            // Grow(); instance method 
            var x01 = new X();
            x01.Grow();
            // ReturnFixedData(); static method
            X.ReturnFixedData();

            // remember STATIC MATHS CLASS WHICH RETURNS PI, LOGX ETC
            Console.WriteLine(Math.PI);

            DoThis();
            DoThis();
            DoThis();

            DoThat();
            DoThat();
            DoThat();
            DoingLots(100, "hi", true);
            DoingLots(c: false, b: "there", a: 10_000_000);

            #endregion  

            // can put methods here
            void DoThis(){ Console.WriteLine("I am doing something"); }

            DoingSomeOtherWork(new DateTime(2019, 06, 27));   //  set date but others default
            DoingSomeOtherWork(new DateTime(2019, 06, 27), 'a',1.3F,100.222);   //  

        }

        static void DoThat() { Console.WriteLine("I am doing something else"); }
        // can put methods here


        static void DoingLots(int a, string b, bool c)
        {
            Console.WriteLine($"Doing lots {a}  {b}  {c}");
        }

        static void DoingSomeOtherWork(DateTime date, char c = 'z', float f = 1.2F, double d = 100.329) {
            
            Console.WriteLine($"{date},{c},{f},{d}");

            string newday = date.ToShortDateString();

            Console.WriteLine($"{newday},{c},{f},{d}");

                newday = date.ToLongDateString();

            Console.WriteLine($"{newday},{c},{f},{d}");
            newday = date.AddDays(3).ToLongDateString();
            string weekday = date.DayOfWeek.ToString();
            Console.WriteLine($"{weekday},{c},{f},{d}");

        }



    }
    class X
    {
        public int Age;
        // can put INSTANCE Nmethods here
        public void Grow()
        {
            Age++;
        }
        // STATIC METHOD : useful for fixed data : STATIC=stock warehouse (WHOLE APP)
        public static string ReturnFixedData()
        {
            return "Here is some fixed data";
        }
    }
}
