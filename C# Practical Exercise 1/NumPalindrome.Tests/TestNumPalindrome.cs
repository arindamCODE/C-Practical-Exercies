using System;
using Xunit;
using NumPalindrome;

namespace NumPalindrome.Tests
{
    public class TestNumPalindrome
    {
        [Fact]
        public void Test()
        {   
           //Arrange
            PalindromeTest obj1 = new PalindromeTest();
            CheckSumTest obj2 = new CheckSumTest();

            //Act
            bool res1 = obj1.IsAPalindrome(12233221);
            bool res2 = obj1.IsAPalindrome(12222333);
            bool res3 = obj2.IsSumGreater(2468642);
            bool res4 = obj2.IsSumGreater(1221);

            //Assert
            Assert.True(res1);
            Assert.False(res2);
            Assert.True(res3);
            Assert.False(res4);

        }
    }
}
