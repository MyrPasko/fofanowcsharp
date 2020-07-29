using System.Collections.Generic;

namespace B_ControlFlow
{
    public class Parse
    {
        private static Dictionary<char, int> map = new Dictionary<char, int>()
        {
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000},
        };

        public static int ParseNumber(string romanNum)
        {
            int result = 0;

            for (int i = 0; i < romanNum.Length; i++)
            {
                if (i+1 < romanNum.Length && IsSubtractive(romanNum[i], romanNum[i+ 1]))
                {
                    result -= map[romanNum[i]];
                }
                else
                {
                    result += map[romanNum[i]];
                }
            }

            return result;
        }

        private static bool IsSubtractive(char num1, char num2)
        {
            return map[num1] < map[num2];
        }
    }
}