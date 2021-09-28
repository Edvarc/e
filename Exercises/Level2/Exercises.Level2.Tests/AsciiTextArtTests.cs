using System.IO;
using Xunit;

namespace Exercises.Level2.Tests
{
    public class AsciiTextArtTests
    {
        private readonly AsciiTextArt _asciiTextArt = new AsciiTextArt();

        [Fact]
        public void E()
        {
            string[] response = _asciiTextArt.GetArt(GetLetters(), "E", 5, 4);

            Assert.Equal(GetE(), response);
        }

        [Fact]
        public void MANHATTAN()
        {
            string[] response = _asciiTextArt.GetArt(GetLetters(), "MANHATTAN", 5, 4);

            Assert.Equal(GetManhattan(), response);
        }

        [Fact]
        public void ManhAtTan()
        {
            string[] response = _asciiTextArt.GetArt(GetLetters(), "ManhAtTan", 5, 4);

            Assert.Equal(GetManhattan(), response);
        }

        [Fact]
        public void MissingManhattan()
        {
            string[] response = _asciiTextArt.GetArt(GetLetters(), "M@NH@TT@N", 5, 4);

            Assert.Equal(GetMissingManhattan(), response);
        }

        private static string[] GetLetters() => GetFile("AsciiArt-4-5.txt");

        private static string[] GetE() => GetFile("E.txt");

        private static string[] GetManhattan() => GetFile("MANHATTAN.txt");

        private static string[] GetMissingManhattan() => GetFile("MissingManhattan.txt");

        private static string[] GetFile(string name) => File.ReadAllLines($"AsciiFiles/{name}");
    }
}
