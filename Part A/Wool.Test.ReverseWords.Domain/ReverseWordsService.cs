using System;

namespace Wool.Test.ReverseWords.Domain
{
    public class ReverseWordsService
    {
        public static string ResverseString(string input)
        {
            var charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static string ResverseString2(string input)
        {
            var length = input.Length;
            var charArray = new char[length];
            for (int i = length - 1; i >= 0; i--)
            {
                charArray[length-i-1] = input[i];
            }
            return new string(charArray);
        }
    }
}
