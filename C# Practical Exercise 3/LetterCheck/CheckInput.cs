using System;

namespace LetterCheck
{
    class CheckInput
    {
       public void InputCheck()
       {
           try
           {  
                VCCheck obj = new VCCheck();
                Start :
                Console.WriteLine("Please enter the word:");
                string str = Console.ReadLine();
                char[] str1 = str.ToCharArray();
                int len = str1.Length;
                bool res = false;
                for(int i=0; i<len; i++)
                {
                    res = char.IsLetter(str1[i]);
                    if(res == false)
                    {
                        Console.WriteLine("Error!");
                        Console.WriteLine("Please Enter Letters!");
                        goto Start;
                    }         
                }
                obj.CheckVC(str1);
           }catch(Exception ex){
               Console.WriteLine(ex.Message);
           }

        } 
    }
}