namespace Codility
{
    public class Nesting
    {
        public int solution(string S)
        {
            var openingBrackets = 0;

            foreach (var ch in S)
            {
                if (ch == ')' && openingBrackets == 0)
                {
                    return 0;
                }
                else if (ch == ')' && openingBrackets > 0)
                {
                    openingBrackets--;
                }
                else
                {
                    openingBrackets++;
                }
            }

            if (openingBrackets > 0)
            {
                return 0;
            }

            return 1;
        }
    }
}