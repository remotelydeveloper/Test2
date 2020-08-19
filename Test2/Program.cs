using System;
using System.Runtime.CompilerServices;

namespace Test2
{
    class Program
    {
        public static void Main()
        {
            string binaryString = "1110000100";
            bool result = IsGoodBinaryString(binaryString);

            if (result)
            {
                Console.WriteLine(string.Format("{0} is a good binary string", binaryString));
            }
            else
            {
                Console.WriteLine(string.Format("{0} is not a good binary string", binaryString));
            }
        }

        private static bool IsGoodBinaryString(string input)
        {
            if (input.Length % 2 != 0)
            {
                return false;
            }

            for (int i = 1; i < input.Length; i++)
            {
                string substr = input.Substring(0, i);                
                if (CountNumberOne(input) < input.Length / 2)
                {
                    return false;
                }
            }

            return true;
        }

        private static int CountNumberOne(string input)
        {
            int cnt = 0;
            foreach (char c in input)
            {
                if (c == '1') cnt++;
            }
            return cnt;
        }
    }
}
