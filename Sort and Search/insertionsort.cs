namespace Sort_and_Search
{
    class insertsrt
    {
        public static void insertionsort(int[] orglist)//insert sort O(n^2)
        {
            for (var i = 0; i < orglist.Length - 1; i++)
            {
                for (var j = i + 1; j > 0; j--)
                {
                    if (orglist[j] < orglist[j - 1])
                    {
                        Helper.swaplist(orglist, j, j - 1);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            
        }
    }
}
