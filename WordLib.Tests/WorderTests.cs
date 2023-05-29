namespace WordLib.Tests
{
    public class WorderTests
    {
        [Fact]
        public void IsPalindromFact()
        {
            //Arrange
            Worder worder = new Worder();
            bool expected = true;

            //Act
            bool actual = worder.Palindrome("stats");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("stats", true)]
        [InlineData("computer", false)]
        [InlineData("noon", true)]
        [InlineData("monkey", false)]
        public void IsPalindromTheory(string x, bool expected)
        {
            //Arrange
            Worder worder = new Worder();

            //Act
            bool actual = worder.Palindrome(x);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void IsMinimumFiveCharFact()
        {
            //Arrange
            Worder worder = new Worder();
            bool expected = true;

            //Act
            bool actual = worder.FiveOrMoreChar("stats");

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("stats", true)]
        [InlineData("computer", true)]
        [InlineData("noon", false)]
        [InlineData("monkey", true)]
        public void IsMinimumFiveCharTheory(string x, bool expected)
        {
            //Arrange
            Worder worder = new Worder();

            //Act
            bool actual = worder.FiveOrMoreChar(x);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}