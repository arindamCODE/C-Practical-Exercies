using System;

namespace SortNumbers
{
    class GreaterNumbers
    {
        public void NumbersGreater(int[] num)
        {
            try
            {
                int size = num.Length;
                int ctr = 0;
                for(int i=0; i<size; i++)
                {
                    if(num[i]%2 == 0)
                    {
                        ctr += num[i];
                    }
                }
                Console.WriteLine("The Sum is: {0}", ctr);
                if(ctr>15)
                    Console.WriteLine("True");
                else
                    Console.WriteLine("False");
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}