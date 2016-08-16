using PalindromeInText.Interface;

namespace PalindromesStrategy
{
    public class PalindromeN2 : IPalindrome
    {
        public bool IsPalindrome(string verifyPalindrome)
        {
            int countMatches = 0;
            bool checkPalindrom = false;
            for (int i = 0; i < verifyPalindrome.Length / 2; i++)
            {
                for (int j = verifyPalindrome.Length - 1 - i; j >= verifyPalindrome.Length / 2; j--)
                {
                    if (verifyPalindrome[i] == verifyPalindrome[j])
                    {
                        countMatches++;
                        break;
                    }
                }
            }
            if (countMatches == verifyPalindrome.Length / 2)
            {
                checkPalindrom = true;
            }
            return checkPalindrom;
        }
    }
}