namespace Codility
{
    public class MaxNonoverlappingSegments
    {
        public int solution(int[] A, int[] B)
        {
            var overlaps = 0;

            var lastEnd = -1;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > lastEnd)
                {
                    lastEnd = B[i];
                    overlaps++;
                }
            }

            return overlaps;
        }
    }
}