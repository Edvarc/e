using Xunit;

namespace Exercises.Level2.Tests
{
    public class TriangleTests
    {
        private readonly Triangle _triangle = new Triangle();

        [Fact]
        public void Triangle1()
        {
            string[] expected1 = new string[]
            {
                "*"
            };

            Assert.Equal(expected1, _triangle.GetTRiangle(1));
        }

        [Fact]
        public void Triangle3()
        {
            string[] expected = new string[]
            {
                "  *",
                " ***",
                "*****"
            };

            Assert.Equal(expected, _triangle.GetTRiangle(3));
        }

        [Fact]
        public void Triangle4()
        {
            string[] expected = new string[]
            {
                "   *",
                "  ***",
                " *****",
                "*******"
            };

            Assert.Equal(expected, _triangle.GetTRiangle(4));
        }

        [Fact]
        public void Triangle5()
        {
            string[] expected = new string[]
            {
                "    *",
                "   ***",
                "  *****",
                " *******",
                "*********"
            };

            Assert.Equal(expected, _triangle.GetTRiangle(5));
        }

        [Fact]
        public void Triangle10()
        {
            string[] expected = new string[]
            {
                "         *",
                "        ***",
                "       *****",
                "      *******",
                "     *********",
                "    ***********",
                "   *************",
                "  ***************",
                " *****************",
                "*******************",
            };

            Assert.Equal(expected, _triangle.GetTRiangle(10));
        }
    }
}
