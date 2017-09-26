using System;

namespace IntegerCheck
{
    public class IntegerCheckTest
    {
        public bool IsNumberBetween(int num)
        {
            if(num>=20 && num<=30)
                return true;
            else
                return false;
        }
    }
}