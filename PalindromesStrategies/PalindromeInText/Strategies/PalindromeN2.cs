using PalindromesStrategy.Interface;

namespace PalindromesStrategy.Strategies
{
    public class PalindromeN2 : IPalindrome
    {
        public bool IsPalindrome(string str)
        {
            int countMatches = 0;
            bool checkPalindrom = false;
            for (int i = 0; i < str.Length / 2; i++)
            {
                for (int j = str.Length - 1 - i; j >= str.Length / 2; j--)
                {
                    if (str[i] == str[j])
                    {
                        countMatches++;
                        break;
                    }
                }
            }
            if (countMatches == str.Length / 2)
            {
                checkPalindrom = true;
            }
            return checkPalindrom;
        }
    }
}