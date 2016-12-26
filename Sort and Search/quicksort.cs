using System;

namespace Sort_and_Search
{
    class quicksrt
    {
        public static int partition(int[] orglist, int low, int high)// partition
        {
            int pivot = orglist[low];
            int l = low;
            int h = high;
            while (l < h)
            {
                while (orglist[l] <= pivot && l < h)
                {
                    l++;
                }
                while (orglist[h] > pivot)
                {
                    h--;
                }
                if (l < h)
                {
                    Helper.swaplist(orglist, l, h);
                }
            }
            Helper.swaplist(orglist, low, h);
            return h;
        }

        public static void quicksort(int[] orglist, int low, int high)// O(NlogN)
        {
            if (low >= high)
            {
                return;
            }
            int pivotindex = partition(orglist, low, high);
            quicksort(orglist, low, pivotindex - 1);
            quicksort(orglist, pivotindex + 1, high);
            
        }
    }
}
