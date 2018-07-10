namespace Codility
{
    public class Peaks
    {
        public int solution(int[] A)
        {
            var accumulations = new int[A.Length];

            for (int i = 1; i < A.Length - 1; i++)
            {
                var delta = (A[i] > A[i - 1] && A[i] > A[i + 1]) ? 1 : 0;
                accumulations[i] = accumulations[i - 1] + delta;
            }

            if (A.Length > 1)
            {
                accumulations[A.Length - 1] = accumulations[A.Length - 2];
            }

            var splits = A.Length;

            while (splits > 0)
            {
                if (A.Length % splits == 0)
                {
                    var blockSize = A.Length / splits;
                    var last = 0;
                    var good = true;
                    for (int i = 1; i <= splits; i++)
                    {
                        var currentIndex = i * blockSize - 1;
                        if (accumulations[currentIndex] == last)
                        {
                            good = false;
                            break;
                        }
                        else
                        {
                            last = accumulations[currentIndex];
                        }
                    }

                    if (good)
                    {
                        return splits;
                    }
                }

                splits--;
            }

            return 0;
        }
    }
}