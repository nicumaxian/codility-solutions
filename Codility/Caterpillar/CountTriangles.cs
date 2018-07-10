using System;

namespace Codility
{
    public class CountTriangles
    {
        public int solution(int[] A)
        {
            if (A.Length < 3)
            {
                return 0;
            }

            Array.Sort(A);

            var result = 0;

            for (int a = 0; a < A.Length - 2; a++)
            {
                var b = a + 1;
                var c = b + 1;

                while (c < A.Length)
                {
                    if (A[a] + A[b] > A[c])
                    {
                        result += c - b;
                        c++;
                    }
                    else if (b < c - 1)
                    {
                        b++;
                    }
                    else
                    {
                        c++;
                        b++;
                    }
                }
            }

            return result;
        }
    }
}