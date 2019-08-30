using System;
using System.Net;
using System.Diagnostics;

namespace lab_63_web_streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            // read a web page
            Uri bbcNews01 = new Uri("https://www.bbc.co.uk/sport");

            // URI Uniform resource IDENTIFIER     - more general pointer        
            // URL Uniform resource LOCATOR        - more specific

            Console.WriteLine(bbcNews01.Host);
            Console.WriteLine(bbcNews01.Port);
            Console.WriteLine(bbcNews01.AbsolutePath);

            // download this file 


            var s = new Stopwatch();
            s.Start();
            GetWebPageSync();
            s.Stop();
            Console.WriteLine(s.ElapsedMilliseconds);

            var t = new Stopwatch();
            t.Start();
            GetWebPageAsync();
            t.Stop();
            Console.WriteLine(t.ElapsedMilliseconds);

            Console.ReadLine();

        }

        static void GetWebPageSync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };
            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            downloadWebPage01.DownloadFile(albarahi, "albahari.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }

        async static void GetWebPageAsync()
        {
            var downloadWebPage01 = new WebClient { Proxy = null };
            var albarahi = new Uri("http://www.albahari.com/nutshell/code.aspx");
            await downloadWebPage01.DownloadFileTaskAsync(albarahi, "albahari.html");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", "albahari.html");
        }



        // NOTE : WEBCLIENT
        // NOTE : HTTPWEBREQUEST/RESPONSE GIVE MORE DETAIL / PREFFERED TO USE 



    }
}
