using System;

namespace NumPalindrome
{
    public class CheckSumTest
    {
        public bool IsSumGreater(int num)
        {
                int ctr = 0;
                string s;
                string str = num.ToString();
                char[] num1 = str.ToCharArray();
                int size = num1.Length;
                int[] num2 = new int[size];

                for (int i = 0; i < size; i++)
                {
                    s = num1[i].ToString();
                    num2[i] = Convert.ToInt32(s);
                }

                for (int i = 0; i < size; i++)
                {
                    if (num2[i] % 2 == 0)
                    {
                        ctr += num2[i];
                    }
                }

                if(ctr>25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
        }
    }
}