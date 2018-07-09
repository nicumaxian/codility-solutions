namespace Codility
{
    public class EquiLeader
    {
        public int solution(int[] A)
        {
            var size = 0;
            var last = -1;

            foreach (var value in A)
            {
                if (size == 0)
                {
                    last = value;
                    size++;
                }
                else
                {
                    if (last == value)
                    {
                        size++;
                    }
                    else
                    {
                        size--;
                    }
                }
            }

            if (size == 0)
            {
                return 0;
            }

            var counts = 0;
            var lastIndex = -1;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == last)
                {
                    counts++;
                    lastIndex = i;
                }
            }

            if (counts > A.Length / 2)
            {
                var dominator = last;
                var leftCounts = 0;
                var equeLeaders = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (leftCounts > i / 2 && (counts - leftCounts) > (A.Length - i) / 2)
                    {
                        equeLeaders++;
                    }

                    if (A[i] == dominator)
                    {
                        leftCounts++;
                    }
                }

                return equeLeaders;
            }

            return 0;
        }
    }
}