using System;

namespace LetterCheck
{
    public class InputTest
    {
        public bool CheckType(string str1)
        {
            char[] str = str1.ToCharArray();
            int len = str.Length;
            bool result = false;
            for(int i=0; i<len; i++)
            {
                if(char.IsLetter(str[i]))
                    result = true;
                else
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
    }
}