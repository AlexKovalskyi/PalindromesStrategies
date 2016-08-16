using PalindromesStrategy.Interface;

namespace PalindromesStrategy.Strategies
{
    internal class PalindromeN3 : IPalindrome
    {
        public bool IsPalindrome(string str)
        {
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = str[min];
                char b = str[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
