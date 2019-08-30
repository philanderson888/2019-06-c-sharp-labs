﻿using System;
using System.Text.RegularExpressions;

namespace lab_25_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s01 = "hi there";
            // string s02 = 'hi';
            // use array notation to get individual letters
            foreach (var c in s01)
            {
                Console.WriteLine(c);
            }
            // access individual letters using array notation []
            Console.WriteLine($"Fifth character is {s01[4]}");
            Console.WriteLine("\n\n");
            for(int i = 0; i < s01.Length; i++)
            {
                Console.WriteLine(s01[i]);
            }
            string s02 = "hi";
            String s03 = "there";

            Console.WriteLine(s02);
            Console.WriteLine(s03);

            // parsing to integer
            int num01 = int.Parse("1234");
            Console.WriteLine(num01);
            Console.WriteLine($"Type of num01 is {num01.GetType()}");

            try
            {
                // don't use parse because it will throw an exception and crash your computer
                int num02 = int.Parse("1234sometext");
                Console.WriteLine(num02);

                int num03 = int.Parse("sometext1234sometext");
                Console.WriteLine(num03);

                int num04 = int.Parse("sometext");
                Console.WriteLine(num04);
            }
            catch (Exception e)
            {
                Console.WriteLine("Don't use parse!!!!!");
                Console.WriteLine(e);
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("back to nornal");
            }



            // int.tryParse
            int.TryParse("123abc",out int output01);
            Console.WriteLine(output01);
            // int.tryParse
            int.TryParse("abc123", out int output02);
            Console.WriteLine(output02);
            // int.tryParse
            int.TryParse("abc", out int output03);
            Console.WriteLine(output03);

            int.TryParse("123", out int output04);
            Console.WriteLine(output04);


            int output05 = Convert.ToInt32
               (
                   Regex.Replace
                   (
                       "7yu4805jqwfwei321",    // input
                       "[^0-9]",               // select everything that is not in the range of 0-9
                       ""                      // replace that with an empty string.
                   )
               );
            Console.WriteLine(output05);



            // String.Format and String Interpolation
            double d01 = 1.234;
            Console.WriteLine(String.Format("{0,10:N0}", d01));
            Console.WriteLine(String.Format("{0,10:N1}", d01));
            Console.WriteLine(String.Format("{0,10:N2}", d01));

            Console.WriteLine($"{d01,10:N0}");
            Console.WriteLine($"{d01,10:N1}");
            Console.WriteLine($"{d01,10:N2}");

            // Column Width
            Console.WriteLine($"{d01,10:N0}{d01,10:N1}{d01,10:N2}");
            Console.WriteLine($"{d01,20:N0}{d01,20:N1}{d01,20:N2}");

            // currency

            Console.WriteLine($"{d01,10:C}{d01,10:N0}{d01,10:N1}{d01,10:N2}");


            // string.split


            string sentence = "Food is life";
            string[] words = sentence.Split(' ');
            foreach(var word in words)
            {
                Console.WriteLine(word);
            }


            // array.join

            string sentence02;
            sentence02 = string.Join(" ", words);
            Console.WriteLine(sentence02);



            //StartsWith

            //Contains
            String str = "GeeksforGeeks";
            String substr1 = "for";
            String substr2 = "For";
            Console.WriteLine(str.Contains(substr1));
            Console.WriteLine(str.Contains(substr2));


            //Trim/TrimStart/TrimEnd
            Console.WriteLine("   trim this string        ".Trim());
            Console.WriteLine("   trim this string        ".TrimStart());
            Console.WriteLine("   trim this string        ".TrimEnd());


            // ToUpper/Lower
            string str1 = "food";
            string str2 = str1.ToUpper();
            string str3 = str2.ToLower();
            Console.WriteLine(str2);
            Console.WriteLine(str3);


            //.Insert/Remove
            // initialise and write original string
            String original = "abc123";
            Console.WriteLine("The original string: '{0}'", original);

            // Insert white space after character 3
            String modified = original.Insert(3, " ");
            Console.WriteLine("The modified string: '{0}'", modified);

            // Remove 1 character after character 3 (white space from before)
            Console.WriteLine("The modified string is: {0}", modified.Remove(3, 1));



            //.Replace
            string s07 = " i have a banana";
            Console.WriteLine(s07.Replace("banana", "headache")); 



            //.Concat
            string concat = string.Concat("some" + "text");

            //.IsNullOrEmpty
            // .IsNullOrEmpty
            string s1 = "Eng35";
            string s2 = "";
            string s3 = null;
            bool b1 = string.IsNullOrEmpty(s1); //False
            bool b2 = string.IsNullOrEmpty(s2); //True
            bool b3 = string.IsNullOrEmpty(s3); //True
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);


            //.IsNullOrWhitespace


            // Empty
            var string01 = String.Empty;


          


        }
    }
}
