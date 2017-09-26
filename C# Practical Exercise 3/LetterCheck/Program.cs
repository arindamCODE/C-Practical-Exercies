using System;

namespace LetterCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CheckInput obj = new CheckInput();
                obj.InputCheck();
            }catch(Exception ex){
                Console.WriteLine(ex.Message);
            }
        }
    }
}
