using PalindromeExercise;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("kayak", true)]
        [InlineData("sad", false)]
        [InlineData("run", false)]
        [InlineData("noon", true)]
        [InlineData("wow", true)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string a, bool expected)
        {
            //Arrange
            var w = new WordSmith();

            //Act
            var actual = w.IsAPalindrome(a);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
