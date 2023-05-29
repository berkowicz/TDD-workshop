namespace WordLib.Tests
{
    public class WordTester
    {
        [Fact]
        public void IsPalindrom()
        {
            //Arrange
            Worder worder = new Worder();
            string expected = "stats";

            //Act
            string actual = worder.Reverse("status");

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}