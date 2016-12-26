using System;
namespace Sort_and_Search
{
    public class Helper
    {
        //This method prints the list.
        public static void printList(int[] orglist)
        {
            for (var i = 0; i < orglist.Length; i++)
            {
                Console.Write(orglist[i] + ",");
            }
        }
        //This method swaps items in position i and j within orglist
        public static void swaplist(int[] orglist, int i, int j)
        {
            int tmp = orglist[i];
            orglist[i] = orglist[j];
            orglist[j] = tmp;
        }
    }
}
