using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace lab_62_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Stopwatch();
            s.Start();



            // stream to WRITE A FILE
            using (var writer = new StreamWriter("output.txt"))
            {
                for (int i = 0; i < 10000; i++)
                {
         //           writer.WriteLine($"Line {i} - adding some text {DateTime.Now} : elapsed time {s.ElapsedTicks}");
                }
            }
            s.Stop();
            // 19ms
            // 24ms
            // 38ms
            // 0.013_349_2


            var t = new Stopwatch();
            t.Start();
            // see if string builder a bit faster???
            var stringbuilder = new StringBuilder();
            for (int i = 0; i < 10000; i++)
            {
                stringbuilder.Append($"Line {i} - adding some text {DateTime.Now} : elapsed time {t.ElapsedTicks}\n");
            }
            using (var writer = new StreamWriter("output2.txt"))
            {
          //      writer.WriteLine(stringbuilder);
            }
            t.Stop();

            // 9ms
            // 16ms
            // 20
            // 0.007_407_4   7ms


            var u = new Stopwatch();
            u.Start();
            string nextline;
            var stringbuilder2 = new StringBuilder();
            using (var reader = new StreamReader("output.txt"))
            {
                // two operations 1) read next line and assign into string 'nextline'   2) check has not returned null
                while ((nextline = reader.ReadLine()) != null)
                {
                    stringbuilder2.AppendLine(nextline);
                }
            }
            Console.WriteLine($"read file to memory {u.ElapsedTicks}");

            Console.WriteLine(stringbuilder2);
            Console.WriteLine($"output file to console {u.ElapsedTicks}");
            u.Stop();
                // 0.000_900_0    0.9 milliseconds
                //  1.3ms
                //  4




            // stream reader async - see lab 50


            // last example - streaming to memory (used eg in encryption)

            // use a 'pointer' which is a reference to an address in memory
            // read data from pointer forwards

            using (var memorystream = new MemoryStream())
            {
                var buffer = new byte[100];
                buffer[0] = (int)'h';
                buffer[1] = (int)'e';
                buffer[2] = (int)'l';
                buffer[3] = (int)'l';
                buffer[4] = (int)'o';

                // write data to memory
                memorystream.Write(buffer);
                memorystream.Flush();          // actively push remaining data to memory

                // get meaningful data back?
                // reset pointer to 0
                memorystream.Position = 0;
                var reader = new StreamReader(memorystream);
                Console.WriteLine(reader.ReadToEnd());

            }
        }
    }
}
