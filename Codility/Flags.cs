using System.Collections.Generic;

namespace Codility
{
    public class Flags
    {
        public int solution(int[] A)
        {
            var array = new List<int>();
            for (var i = 1; i < A.Length - 1; i++)
            {
                if (A[i - 1] < A[i] && A[i + 1] < A[i])
                {
                    array.Add(i);
                }
            }

            if (array.Count == 1 || array.Count == 0)
            {
                return array.Count;
            }

            var result = 1;

            var step = 2;

            while (true)
            {
                var lastPosition = array[0];
                var good = false;
                var goodElements = 1;

                for (var i = 1; i < array.Count; i++)
                {
                    var element = array[i];
                    if (lastPosition + step <= element)
                    {
                        lastPosition = element;
                        goodElements++;

                        if (goodElements == step)
                        {
                            good = true;
                            break;
                        }
                    }
                }

                if (good)
                {
                    result = step;
                }
                else
                {
                    return result;
                }

                step++;
            }
        }
    }
}