using System;

namespace StringInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a string");
                string str = Console.ReadLine();
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                int ctr = num;
                char[] str1 = str.ToCharArray();
                int len = str1.Length;

                Console.Write(str);
                while(ctr != 0)
                {
                    for(int i=(len-num); i<len; i++)
                    {
                     Console.Write(str1[i]);
                    }
                    ctr--;
                }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
