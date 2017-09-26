using System;
using Xunit;
using IntegerCheck;

namespace IntegerCheck.Test
{
    public class IntegerTest
    {
        [Fact]
        public void Testinteger()
        {
            //Arrange
            IntegerCheckTest obj = new IntegerCheckTest();

            //Act
            bool res1 = obj.IsNumberBetween(24);
            bool res2 = obj.IsNumberBetween(34);

            //Arrrange
            Assert.IsType<bool>(res1);
            Assert.IsType<bool>(res2);

            Assert.True(res1);
            Assert.False(res2);
        }
    }
}