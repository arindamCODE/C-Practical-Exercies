using System;

namespace SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SortMethod obj = new SortMethod();
                Console.WriteLine("Please enter the size:");
                int size = int.Parse(Console.ReadLine());
                int[] num = new int[size];
                Console.WriteLine("Please enter the numbers one by one:");
                for(int i=0; i<size; i++)
                {
                    num[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("The Array you entered is:");
                for(int i=0; i<size; i++)
                {
                    Console.Write(num[i]+" ");
                }
                Console.WriteLine();
                obj.Sort(num);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
