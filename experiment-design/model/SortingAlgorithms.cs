

namespace experiment_design.model
{
    public class SortingAlgorithms
    {
        public int[] MergeSort(int[] arr)
        {
            if (arr.Length < 2)
            {
                return arr;
            }

            int[] left;
            int[] right;

            int mid = arr.Length / 2;
            left = new int[mid];

            if (arr.Length % 2 == 0)
                right = new int[mid];
            else
                right = new int[mid + 1];

            for (int i = 0; i < mid; i++)
            {
                left[i] = arr[i];       
            }

            int x = 0;
            for (int i = mid; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            left = MergeSort(left);
            right = MergeSort(right);

            return merge(left, right);



        }

        private int[] merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];

            int idxL = 0;
            int idxR = 0;
            int idxRes = 0;

            while (idxL < left.Length || idxR < right.Length)
            {
                if (idxL < left.Length && idxR < right.Length)
                {
                    if (left[idxL]<=right[idxR])
                    {
                        result[idxRes] = left[idxL];
                        idxL++;
                        idxRes++;
                    }
                    else
                    {
                        result[idxRes] = right[idxR];
                        idxR++;
                        idxRes++;
                    }
                }
                else if (idxL<left.Length)
                {
                    result[idxRes] = left[idxL];
                    idxL++;
                    idxRes++;
                }
                else if (idxR<right.Length)
                {
                    result[idxRes] = right[idxR];
                    idxR++;
                    idxRes++;
                }
            }

            return result;
        }
    }
}