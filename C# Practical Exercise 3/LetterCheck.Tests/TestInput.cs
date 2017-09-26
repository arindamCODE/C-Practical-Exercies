using System;
using Xunit;
using LetterCheck;

namespace LetterCheck.Tests
{
    public class TestInput
    {
        [Fact]
        public void Test()
        {
            //Arrange
            InputTest obj = new InputTest();

            //Act
            bool res = obj.CheckType("aaaa");
            bool res1 = obj.CheckType("aakk222");

            //Assert
            Assert.True(res);
            Assert.False(res1);
        }
    }
}
