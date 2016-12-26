using System;
namespace Sort_and_Search
{
    class shellsrt
    {
        //shell sort
        public static void modifiedinsertionsort(int[] orglist, int startindex, int increment)//modified insert sort
        {
            for (var i = startindex; i < orglist.Length; i = i + increment)
            {
                var min = Math.Min(i + 1, orglist.Length - 1);
                for (var j = min; j - increment >= 0; j = j - increment)
                {
                    if (orglist[j] < orglist[j - increment])
                    {
                        Helper.swaplist(orglist, j, j - increment);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void shellsort(int[] orglist)//shell sort - Lies somewhere between O(N) and O(n^2)
        {
            var increment = orglist.Length / 2;
            while (increment >= 1)
            {
                for (var startindex = 0; startindex < increment; startindex++)
                {
                    modifiedinsertionsort(orglist, startindex, increment);
                }
                increment = increment / 2;
            }
           
        }
    }
}