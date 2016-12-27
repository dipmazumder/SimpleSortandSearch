namespace Sort_and_Search
{
    class BinarySearch
    {
        public static int binarysearch(int[] orglist, int number, int min, int max)
        {
            if (min >= max) {
                return -1;
            }
            int midpoint = min + (max - min) / 2;
            if (orglist[midpoint] == number) {
                return midpoint;
            }
            if (orglist[midpoint] > number)
            {
                return binarysearch(orglist, number, min, midpoint - 1);
            }
            else {
                return binarysearch(orglist, number, midpoint+1, max);
            }        
        }
    }
}
