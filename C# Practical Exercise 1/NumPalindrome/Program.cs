using System;

namespace NumPalindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Palindrome obj = new Palindrome();
                int num;
                Console.WriteLine("Please enter the number:");
                num = int.Parse(Console.ReadLine());
                obj.CheckPalindrome(num);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }    
        } 
    }
}
