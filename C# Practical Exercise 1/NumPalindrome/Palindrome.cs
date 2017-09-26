using System;

namespace NumPalindrome
{
    class Palindrome
    {
        public void CheckPalindrome(int num)
        {
            try
            {
                CheckSum cs = new CheckSum();
                int temp = num;
                int rem, rev = 0;
                while(num > 0)
                {
                    rem = num % 10;
                    rev = rev*10 + rem;
                    num /= 10;
                }
                if(temp == rev)
                {
                    Console.WriteLine("Yes, The number is Palindrome!");
                    Console.WriteLine("Success!");
                    cs.SumCheck(temp);
                }
                else
                {
                    Console.WriteLine("No, The number is not Palindrome!");
                    Console.WriteLine("Failure!");
                }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        } 
    }  
}