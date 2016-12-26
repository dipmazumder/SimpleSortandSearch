namespace Sort_and_Search
{
    public class SelectSort
    {
        public static void selectionsort(int[] orglist)//selection sort O(N^2)
        {
            for (var i = 0; i < orglist.Length; i++)
            {
                for (var j = i + 1; j < orglist.Length; j++)
                {
                    if (orglist[i] > orglist[j])
                    {
                        Helper.swaplist(orglist, i, j);
                    }
                }
            }
           
        }
    }
}
