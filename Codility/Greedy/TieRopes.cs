namespace Codility
{
    public class TieRopes
    {
        public int solution(int K, int[] A)
        {
            var lastRopeSize = 0;
            var tiedRopes = 0;

            for (var i = 0; i < A.Length; i++)
            {
                if (lastRopeSize + A[i] >= K)
                {
                    lastRopeSize = 0;
                    tiedRopes++;
                }
                else
                {
                    lastRopeSize += A[i];
                }
            }

            return tiedRopes;
        }
    }
}