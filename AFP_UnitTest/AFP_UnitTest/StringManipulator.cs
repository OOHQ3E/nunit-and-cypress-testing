using System;

namespace AFP_UnitTest
{
    public class StringManipulator
    {
        public string reverse(string input)
        {
            string reversed = "";
            if (input == null)
            {
                throw new ArgumentNullException("input cannot be null");
            }

            for (int i = input.Length -1; i  >= 0; i--)
            {
                reversed += input[i];
            }
            return reversed;
        }

        public int countOccurances(string input, char target)
        {
            if (input == null)
            {
                throw new ArgumentNullException("input cannot be null");
            }
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == target)
                {
                    count++;
                }
            }
            return count;
        }

        public string concatenate(string input1, string input2)
        {
            if (input1 == null || input2 == null)
            {
                throw new InvalidOperationException("inputs cannot be null!");
            }
            return input1 + input2;
        }
    }
}
