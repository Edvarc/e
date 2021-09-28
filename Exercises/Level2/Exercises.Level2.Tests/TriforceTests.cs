using Xunit;

namespace Exercises.Level2.Tests
{
    public class TriforceTests
    {
        private readonly Triforce _triforce = new Triforce();

        [Fact]
        public void Triforce1()
        {
            string[] expected1 = new string[]
            {
                " *",
                "* *"
            };

            Assert.Equal(expected1, _triforce.GetTriforce(1));
        }

        [Fact]
        public void Triforce3()
        {
            string[] expected = new string[]
            {
                "     *",
                "    ***",
                "   *****",
                "  *     *",
                " ***   ***",
                "***** *****"
            };

            Assert.Equal(expected, _triforce.GetTriforce(3));
        }

        [Fact]
        public void Triforce4()
        {
            string[] expected = new string[]
            {
                "       *",
                "      ***",
                "     *****",
                "    *******",
                "   *       *",
                "  ***     ***",
                " *****   *****",
                "******* *******"
            };

            Assert.Equal(expected, _triforce.GetTriforce(4));
        }

        [Fact]
        public void Triforce5()
        {
            string[] expected = new string[]
            {
                "         *",
                "        ***",
                "       *****",
                "      *******",
                "     *********",
                "    *         *",
                "   ***       ***",
                "  *****     *****",
                " *******   *******",
                "********* *********"
            };

            Assert.Equal(expected, _triforce.GetTriforce(5));
        }

        [Fact]
        public void Triforce10()
        {
            string[] expected = new string[]
            {
                "                   *",
                "                  ***",
                "                 *****",
                "                *******",
                "               *********",
                "              ***********",
                "             *************",
                "            ***************",
                "           *****************",
                "          *******************",
                "         *                   *",
                "        ***                 ***",
                "       *****               *****",
                "      *******             *******",
                "     *********           *********",
                "    ***********         ***********",
                "   *************       *************",
                "  ***************     ***************",
                " *****************   *****************",
                "******************* *******************",
            };

            Assert.Equal(expected, _triforce.GetTriforce(10));
        }
    }
}
