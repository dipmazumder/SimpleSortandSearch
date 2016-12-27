using System;
using System.Diagnostics;
using System.Threading;

namespace Sort_and_Search
{
    class Timer
    {
        public static Stopwatch watch;
        public static void startwatch()
        {
            watch = Stopwatch.StartNew();
        }
        public static void stopwatch()
        {
            Thread.Sleep(500);
            watch.Stop();
            Console.WriteLine("Time Taken : " + watch.ElapsedMilliseconds);
            Console.WriteLine("");
        }
    }
}
