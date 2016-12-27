namespace Sort_and_Search
{
    class BinarySearch
    {
        public static int binarysearch(int[] orglist, int number)
        {
            int min = 0;
            int max = orglist.Length - 1;
            while (min <= max)
            {
                int mid = (min + (max - min) / 2);
                if (orglist[mid] == number)
                {
                    return mid;
                }
                if (orglist[mid] > number)
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
    }
}
