namespace Sort_and_Search
{
    class bubblesrt
    {
        public static void bubblesort(int[] orglist) //BUBBLE SORT O(N^2)
        {
            for (var i = 0; i < orglist.Length; i++)
            {
                var isswapped = false;
                for (var j = orglist.Length - 1; j > i; j--)
                {
                    if (orglist[j - 1] > orglist[j])
                    {
                        Helper.swaplist(orglist, j, j - 1);
                    }
                    isswapped = true;
                }
                if (!isswapped)
                {
                    break;
                }
            }
            
        }
    }
}
