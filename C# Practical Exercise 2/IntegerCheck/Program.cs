using System;

namespace IntegerCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your numbner:");
                int num = int.Parse(Console.ReadLine());
                if(num>=20 && num<=30)
                {
                    if(num%2 != 0)
                        Console.WriteLine("Tom");
                    else
                        Console.WriteLine("Jerry");    
                }
                else
                    Console.WriteLine("The number is not between 20 and 30!");
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }        
        }
    }
}
