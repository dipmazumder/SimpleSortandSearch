using System;

namespace Sort_and_Search
{
    class mergesrt
    {
        public static void split(int[] origlist, int[] listfirsthalf, int[] listsecondhalf)// split  a list
        {
            int index = 0;
            int secondhalfindex = listfirsthalf.Length;
            while (index < origlist.Length)
            {
                if (index < secondhalfindex)
                {
                    listfirsthalf[index] = origlist[index];
                }
                else
                {
                    listsecondhalf[index - secondhalfindex] = origlist[index];
                }
                index++;
            }

        }

        public static void merge(int[] orglist, int[] listfirsthalf, int[] listsecondhalf)// Merge split list 
        {
            int midpointindex = 0;
            int firsthalfindex = 0;
            int secondhalfindex = 0;
            while (firsthalfindex < listfirsthalf.Length && secondhalfindex < listsecondhalf.Length)
            {

                if (listfirsthalf[firsthalfindex] < listsecondhalf[secondhalfindex])
                {
                    orglist[midpointindex] = listfirsthalf[firsthalfindex];
                    firsthalfindex++;
                }
                else if (secondhalfindex < listsecondhalf.Length)
                {
                    orglist[midpointindex] = listsecondhalf[secondhalfindex];
                    secondhalfindex++;
                }
                midpointindex++;

            }
            if (firsthalfindex < listfirsthalf.Length)
            {
                while (midpointindex < orglist.Length)
                {
                    orglist[midpointindex++] = listfirsthalf[firsthalfindex++];
                }
            }
            if (secondhalfindex < listsecondhalf.Length)
            {
                while (midpointindex < orglist.Length)
                {
                    orglist[midpointindex++] = listsecondhalf[secondhalfindex++];
                }
            }
        }

        public static void mergesort(int[] orglist)// Merge sort O(NlogN)
        {
            if (orglist.Length == 1)
            {
                return;
            }

            int midpoint = orglist.Length / 2 + orglist.Length % 2;
            int[] listfirsthalf = new int[midpoint];
            int[] listsecondhalf = new int[orglist.Length - midpoint];
            split(orglist, listfirsthalf, listsecondhalf);

            mergesort(listfirsthalf);
            mergesort(listsecondhalf);
            merge(orglist, listfirsthalf, listsecondhalf);
            
        }
    }
}
