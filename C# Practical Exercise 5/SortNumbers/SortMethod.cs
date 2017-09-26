using System;

namespace SortNumbers
{
    class SortMethod
    {
        GreaterNumbers obj = new GreaterNumbers();
        public void Sort(int[] num)
        {
            try
            {
                int len = num.Length;
                int temp=0;
                for(int i=0; i<len; i++)
                {
                    for(int j=0; j< ((len-i)-1); j++)
                    {
                         if(num[j]<num[j+1])
                        {
                            temp = num[j];
                            num[j] = num[j+1];
                            num[j+1] = temp;
                        }   

                    }
                }

                Console.WriteLine("The sorted array is:");
                for(int i=0; i<len; i++)
                {
                    Console.Write(num[i]+" ");
                }
                Console.WriteLine();
                obj.NumbersGreater(num);
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}