using System;

namespace NumPalindrome
{
    public class PalindromeTest
    {
        public bool IsAPalindrome(int num)
        {
                int temp = num;
                int rem, rev = 0;
                while (num > 0)
                {
                    rem = num % 10;
                    rev = rev * 10 + rem;
                    num /= 10;
                }
                if(temp==rev)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}