using System;

namespace LetterCheck
{
    class VCCheck
    {
        public void CheckVC(char[] str)
        {
           try
           {
                int len = str.Length;
                for(int i=0; i<len; i++)
                {
                    if(str[i]=='a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                    {
                        Console.Write("Vowel ");
                    }
                    else
                    {       
                        Console.Write("Consonant ");
                    }
                }
           }catch(Exception ex){
               Console.WriteLine(ex.Message);
           } 
        }
    }
}