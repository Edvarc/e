using Xunit;

namespace Exercises.Level2.Tests
{
    public class WordsInBoxTests
    {
        private readonly WordsInBox _wordsInBox = new WordsInBox();

        [Fact]
        public void Home()
        {
            string[] expected = new string[] 
            {
                "********",
                "* Home *",
                "********"
            };

            Assert.Equal(expected, _wordsInBox.GetBox("Home"));
        }

        [Fact]
        public void School()
        {
            string[] expected = new string[]
            {
                "****************",
                "* *@!School!@* *",
                "****************"
            };

            Assert.Equal(expected, _wordsInBox.GetBox("*@!School!@*"));
        }

        [Fact]
        public void Empty()
        {
            string[] expected = new string[]
            {
                "****",
                "*  *",
                "****"
            };

            Assert.Equal(expected, _wordsInBox.GetBox(""));
        }

        [Fact]
        public void A()
        {
            string[] expected = new string[]
            {
                "*****",
                "* A *",
                "*****"
            };

            Assert.Equal(expected, _wordsInBox.GetBox("A"));
        }

        [Fact]
        public void InAWeryBeautifullCar()
        {
            string[] expected = new string[]
            {
                "*****************************",
                "* In a very beautifull car! *",
                "*****************************"
            };

            Assert.Equal(expected, _wordsInBox.GetBox("In a very beautifull car!"));
        }
    }
}
