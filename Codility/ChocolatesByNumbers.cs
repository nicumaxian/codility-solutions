namespace Codility
{
    public class ChocolatesByNumbers
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

        public int solution(int N, int M)
        {
            return N / gcd(N, M);
        }
    }
}