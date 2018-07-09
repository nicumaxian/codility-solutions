namespace Codility
{
    public class CommonPrimeDivisors
    {
        public int gcd(int a, int b)
        {
            while (a % b != 0)
            {
                var c = b;
                b = a % b;
                a = c;
            }

            return b;
        }

        public bool isGood(int a, int b)
        {
            while (true)
            {
                var temp = gcd(a, b);
                if (temp == 1)
                {
                    return a == 1;
                }

                a /= temp;
            }
        }

        public int solution(int[] A, int[] B)
        {
            var cnt = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (isGood(A[i], B[i]) && isGood(B[i], A[i]))
                {
                    cnt++;
                }
            }

            return cnt;
        }
    }
}