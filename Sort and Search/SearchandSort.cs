using System;

namespace Sort_and_Search
{
    class SearchandSort
    {
        static void Main(string[] args)
        {
            int[] orglist = new int[] { 4, 5, 6, 2, 1, 7, 10, 3, 9, 8 };
            Console.WriteLine("ORIGINAL LIST");
            Helper.printList(orglist);            
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("SELECTION SORT - O(N^2)");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            SelectSort.selectionsort(orglist);//selection sort
            System.Threading.Thread.Sleep(500);
            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : "+ elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");

             Console.WriteLine("BUBBLE SORT - O(N^2)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            bubblesrt.bubblesort(orglist);//bubble sort
            
            System.Threading.Thread.Sleep(500);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
             Console.WriteLine("");


            Console.WriteLine("INSERTION SORT - O(N^2)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            insertsrt.insertionsort(orglist);//insrtion sort
            
            System.Threading.Thread.Sleep(500);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");
            
             Console.WriteLine("SHELL SORT - O(N^2)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            shellsrt.shellsort(orglist);//shell sort
            
            System.Threading.Thread.Sleep(500);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");
            
             Console.WriteLine("MERGE SORT - O(NLogN)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            mergesrt.mergesort(orglist);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("QUICK SORT- O(NLogN)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            quicksrt.quicksort(orglist, 0, orglist.Length - 1);
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Helper.printList(orglist);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");



            Console.WriteLine("BINARY SEARCH- O(LogN)");
            watch = System.Diagnostics.Stopwatch.StartNew();
            int numbertosearch = 9;
            var value = BinarySearch.binarysearch(orglist, numbertosearch);           
            watch.Stop();
            elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine(value);
            Console.WriteLine("");
            Console.WriteLine("Time Taken : " + elapsedMs);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Read();
        }
    }
}
