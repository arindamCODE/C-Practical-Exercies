using System;

namespace LoopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a number:");
                int num = int.Parse(Console.ReadLine());;
                for(int i=1; i<=num; i++)
                {
                    for(int j=1; j<=i; j++)
                    {
                        Console.Write(i+" ");
                    }
                 }
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
