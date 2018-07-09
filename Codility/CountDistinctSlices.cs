namespace Codility
{
    public class CountDistinctSlices
    {
        public int solution(int M, int[] A)
        {
            var solutions = 0;
            var present = new bool[M + 1];

            var left = 0;
            var right = 0;

            while (right < A.Length)
            {
                if (!present[A[right]])
                {
                    present[A[right]] = true;
                    right++;
                    solutions += right - left;
                }
                else
                {
                    while (present[A[right]])
                    {
                        present[A[left]] = false;
                        left++;
                    }
                }

                if (solutions > 1000000000)
                {
                    return 1000000000;
                }
            }

            return solutions;
        }
    }
}