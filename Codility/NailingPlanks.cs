using System;

namespace Codility
{
    public class NailingPlanks
    {
        struct NailPosition
        {
            public NailPosition(int position, int index)
            {
                Position = position;
                Index = index;
            }

            public int Position { get; }

            public int Index { get; }
        }


        public int solution(int[] A, int[] B, int[] C)
        {
            var nails = new NailPosition[C.Length];
            for (int i = 0; i < C.Length; i++)
            {
                nails[i] = new NailPosition(C[i], i);
            }

            Array.Sort(nails, (a, b) =>
            {
                if (a.Position == b.Position)
                {
                    return a.Index.CompareTo(b.Index);
                }

                return a.Position.CompareTo(b.Position);
            });

            var maxIndex = -1;

            for (int i = 0; i < A.Length; i++)
            {
                var startPlank = A[i];
                var endPlank = B[i];

                maxIndex = GetMinIndexNail(nails, endPlank, startPlank, maxIndex);

                if (maxIndex == -1)
                {
                    return -1;
                }
            }

            return maxIndex + 1;
        }

        private static int GetMinIndexNail(NailPosition[] nails, int endPlank, int startPlank, int maxIndex)
        {
            var start = 0;
            var end = nails.Length - 1;

            var index = -1;
            while (start <= end)
            {
                var mid = (start + end) / 2;

                if (nails[mid].Position > endPlank)
                {
                    end = mid - 1;
                }
                else if (nails[mid].Position < startPlank)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                    index = mid;
                }
            }

            if (index == -1)
            {
                return -1;
            }

            var minIndex = nails[index].Index;

            while (index < nails.Length && nails[index].Position <= endPlank)
            {
                minIndex = Math.Min(minIndex, nails[index].Index);
                if (minIndex <= maxIndex)
                {
                    return maxIndex;
                }

                index++;
            }

            return minIndex;
        }
    }
}