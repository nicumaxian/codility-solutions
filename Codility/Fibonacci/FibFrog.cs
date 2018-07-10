using System;

namespace Codility
{
    public class FibFrog
    {
        public int solution(int[] A)
        {
            var steps = new int[A.Length + 1];
            steps[A.Length] = -1;

            for (int i = 0; i < steps.Length; i++)
            {
                if (i == A.Length || A[i] == 1)
                {
                    var a = 0;
                    var b = 1;
                    while (i - b > -1)
                    {
                        var c = a;
                        a = b;
                        b = b + c;

                        if (i - b > -1 && steps[i - b] > 0)
                        {
                            if (steps[i] == 0 || steps[i] == -1)
                            {
                                steps[i] = steps[i - b] + 1;
                            }
                            else
                            {
                                steps[i] = Math.Min(steps[i], steps[i - b] + 1);
                            }
                        }
                    }

                    if (i - b == -1)
                    {
                        steps[i] = 1;
                    }
                }
            }

            return steps[A.Length];
        }
    }
}