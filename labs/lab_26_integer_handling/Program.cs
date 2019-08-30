using System;

namespace lab_26_integer_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            // Signed Integer  can be positive or negative

            short s01;  // length is 16 bits but 15 bits for data and 1 bit for +/- 
            int i01;    // 32
            long l01;   // 64

            Int16 s02;  // 16
            Int32 i02;  // 32
            Int64 l02;  // 64


            // Unsigned Integer is positive only

            ushort us01;  // Unsigned 16 bit...
            uint ui01;
            ulong ul01;


            // Examples
            Console.WriteLine(short.MaxValue);  // 16 bits but one sign 
                                                // 15 bits 32768
                                                // start at 0, finish 32767
                                                // start at -1, finish -32768
            Console.WriteLine(short.MinValue);
            Console.WriteLine(ushort.MaxValue); // 16 bits => 65536
                                                // start at 0, finish 65535

            // repeat same maths for int (32) and long(64)


        }
    }
}
