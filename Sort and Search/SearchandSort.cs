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
            
            //SELECTION SORT
            Console.WriteLine("SELECTION SORT - O(N^2)");
            Timer.startwatch();
            SelectSort.selectionsort(orglist);
            Timer.stopwatch();          
            Helper.printList(orglist);           
            Console.WriteLine("");

            //BUBBLE SORT
            Console.WriteLine("BUBBLE SORT - O(N^2)");
            Timer.startwatch();
            bubblesrt.bubblesort(orglist);
            Timer.stopwatch();            
            Helper.printList(orglist);
            Console.WriteLine("");

            //INSERTION SORT
            Console.WriteLine("INSERTION SORT - O(N^2)");
            Timer.startwatch();
            insertsrt.insertionsort(orglist);
            Timer.stopwatch();           
            Helper.printList(orglist);
            Console.WriteLine("");

            //SHELL SORT
            Console.WriteLine("SHELL SORT - O(N^2)");
            Timer.startwatch();
            shellsrt.shellsort(orglist);
            Timer.stopwatch();
            Helper.printList(orglist);
            Console.WriteLine("");

            //MERGE SORT
            Console.WriteLine("MERGE SORT - O(NLogN)");
            Timer.startwatch();
            mergesrt.mergesort(orglist);
            Timer.stopwatch();
            Helper.printList(orglist);
            Console.WriteLine("");
                        
            //QUICK SORT
            Console.WriteLine("QUICK SORT- O(NLogN)");
            Timer.startwatch();
            quicksrt.quicksort(orglist, 0, orglist.Length - 1);
            Timer.stopwatch();
            Helper.printList(orglist);
            Console.WriteLine("");

            //BINARY SEARCH
            Console.WriteLine("BINARY SEARCH- O(LogN)");
            Console.Write("Please Enter a value to search :");
            int number_to_search = Convert.ToInt32(Console.ReadLine());
            Timer.startwatch();
            var value = BinarySearch.binarysearch(orglist, number_to_search);
            Timer.stopwatch();
            if (value != -1)
            {
                Console.WriteLine("Value found at position: " + value);
            }
            else {
                Console.WriteLine("Value Not Found.");
            }           
            Console.WriteLine("");
            Console.Read();
        }
    }
}
