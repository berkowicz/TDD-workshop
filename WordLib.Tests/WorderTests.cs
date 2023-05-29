namespace WordLib.Tests
{
    public class WorderTests
    {
        [Fact]
        public void IsPalindrom()
        {
            //Arrange
            Worder worder = new Worder();
            bool expected = true;

            //Act
            bool actual = worder.Palindrome("stats");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}