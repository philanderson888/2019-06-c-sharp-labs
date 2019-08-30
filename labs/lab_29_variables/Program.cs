using System;

namespace lab_29_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // byte
            byte b01 = 0;     // min
            byte b02 = 255;   //max
            byte b03 = 0b_1010_0101;   // binary literal
            byte b04 = 0x_FF;         // 0x is a hexadecimal literal
            byte b05 = 0x_0C;
            Console.WriteLine((int)b05);


            // buffer
            // Youtube : video split into tiny parts
            // each part is size of a 'buffer' 
            // 'video is buffering'
            // buffer is an array of bytes  
            byte[] myBuffer = new byte[4000]; // chunk size for send
                                              // my video


            // char
            // ASCII : first computers maps a NUMBER to every CHARACTER
            // h is 104    H is 72
            char char01 = 'c';
            char char02 = 'd';
            Console.WriteLine(   (int)char01  );

            // unicode is upgrade to ascii
            // utf-8   web   getbootstrap.com 
            // utf-16  unicode ==> chinese characters

            const int num10 = 10;
            // cannot change                   num10 = 100;

            const Double DISPLAY_IT_LIKE_THAT = 5.67;

            var num01 = 10;
            var num02 = "hi";



            // alias
            string xx = "hi";          // use this 
            String yy = "there";      //    String is the class : don't use.
                                      //  Valid use would be :  var s = new String();

            // readonly : use in preference to const
            // const change value to LITERAL (not good)
            // readonly preserve as variable (better)

            // NULL-CHECK

            string AuthorName = null;

            int nameLength = AuthorName.Length;

            if (AuthorName != null)
            {
                Console.WriteLine(AuthorName.Length);
            }

            int? nameLength2 = AuthorName?.Length;
            // if Name is null ==> return null otherwise return length

            int? nullableItem = null;
            //   int cannotMakeNull = null;
            int defaultNumber = default; // 0
            int? defaultNullable = default;  // null
            Console.WriteLine(defaultNullable);



            // NULL-COALESCE

            // TUPLES
            void DoThis() { }

            int DoThat() {
                return -1;
            }

            void DoingSomething (out int result, out string result2)
            {
                result = -1;
                result2 = "hi";
            }

            // TUPLE IS AN ANONYMOUS TYPE 

            // DECLARE
            (string x01, int y01, bool z01) DoingSomethingElse() {
                return ("hi", 10, false);
            }

            // CALL 
            var output01 = DoingSomethingElse();

            // GET INDIVIDUAL ITEMS
            Console.WriteLine($"{output01.x01}{output01.y01}{output01.z01}");









        }
    }

    class X
    {
        public readonly string Y;
    }
}
