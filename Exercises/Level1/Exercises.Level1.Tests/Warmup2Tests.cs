using System;
using Xunit;

namespace Exercises.Level1.Tests
{
    public class Warmup2Theorys
    {
        private Warmup2 _warmup2 = new Warmup2();

        [Theory]
        [InlineData("Hi", 2, "HiHi")]
        [InlineData("Hi", 3, "HiHiHi")]
        [InlineData("Hi", 1, "Hi")]
        [InlineData("Hi", 0, "")]
        [InlineData("Hi", 5, "HiHiHiHiHi")]
        [InlineData("Oh Boy!", 2, "Oh Boy!Oh Boy!")]
        [InlineData("x", 4, "xxxx")]
        [InlineData("", 4, "")]
        [InlineData("code", 2, "codecode")]
        [InlineData("code", 3, "codecodecode")]
        public void StringTimes(string str, int n, string expected)
        {
            Assert.Equal(expected, _warmup2.StringTimes(str, n));
        }

        [Theory]
        [InlineData("Chocolate", 2, "ChoCho")]
        [InlineData("Chocolate", 3, "ChoChoCho")]
        [InlineData("Abc", 3, "AbcAbcAbc")]
        [InlineData("Ab", 4, "AbAbAbAb")]
        [InlineData("A", 4, "AAAA")]
        [InlineData("", 4, "")]
        [InlineData("Abc", 0, "")]
        public void FrontTimes(string str, int n, string expected)
        {
            Assert.Equal(expected, _warmup2.FrontTimes(str, n));
        }

        [Theory]
        [InlineData("abcxx", 1)]
        [InlineData("xxx", 2)]
        [InlineData("xxxx", 3)]
        [InlineData("abc", 0)]
        [InlineData("Hello there", 0)]
        [InlineData("Hexxo thxxe", 2)]
        [InlineData("", 0)]
        [InlineData("Kittens", 0)]
        [InlineData("Kittensxxx", 2)]
        public void CountXX(string str, int expected)
        {
            Assert.Equal(expected, _warmup2.CountXX(str));
        }

        [Theory]
        [InlineData("axxbb", true)]
        [InlineData("axaxax", false)]
        [InlineData("xxxxx", true)]
        [InlineData("xaxxx", false)]
        [InlineData("aaaax", false)]
        [InlineData("", false)]
        [InlineData("abc", false)]
        [InlineData("x", false)]
        [InlineData("xx", true)]
        [InlineData("xax", false)]
        [InlineData("xaxx", false)]
        public void DoubleX(string str, bool expected)
        {
            Assert.Equal(expected, _warmup2.DoubleX(str));
        }

        [Theory]
        [InlineData("Hello", "Hlo")]
        [InlineData("Hi", "H")]
        [InlineData("Heeololeo", "Hello")]
        [InlineData("HiHiHi", "HHH")]
        [InlineData("", "")]
        [InlineData("Greetings", "Getns")]
        [InlineData("Chocoate", "Coot")]
        [InlineData("pi", "p")]
        [InlineData("Hello Kitten", "HloKte")]
        [InlineData("hxaxpxpxy", "happy")]
        public void StringBits(string str, string expected)
        {
            Assert.Equal(expected, _warmup2.StringBits(str));
        }

        [Theory]
        [InlineData("Code", "CCoCodCode")]
        [InlineData("abc", "aababc")]
        [InlineData("ab", "aab")]
        [InlineData("x", "x")]
        [InlineData("fade", "ffafadfade")]
        [InlineData("There", "TThTheTherThere")]
        [InlineData("Kitten", "KKiKitKittKitteKitten")]
        [InlineData("Bye", "BByBye")]
        [InlineData("Good", "GGoGooGood")]
        [InlineData("Bad", "BBaBad")]
        public void StringSplosion(string str, string expected)
        {
            Assert.Equal(expected, _warmup2.StringSplosion(str));
        }

        [Theory]
        [InlineData("hixxhi", 1)]
        [InlineData("xaxxaxaxx", 1)]
        [InlineData("axxxaaxx", 2)]
        [InlineData("xxaxxaxxaxx", 3)]
        [InlineData("xaxaxaxx", 0)]
        [InlineData("xxxx", 2)]
        [InlineData("13121312", 1)]
        [InlineData("11212", 1)]
        [InlineData("13121311", 0)]
        [InlineData("1717171", 2)]
        [InlineData("hi", 0)]
        [InlineData("h", 0)]
        [InlineData("", 0)]
        public void Last2(string str, int expected)
        {
            Assert.Equal(expected, _warmup2.Last2(str));
        }

        [Theory]
        [InlineData(new[] { 1, 2, 9 }, 1)]
        [InlineData(new[] { 1, 9, 9 }, 2)]
        [InlineData(new[] { 1, 9, 9, 3, 9 }, 3)]
        [InlineData(new[] { 1, 2, 3 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 4, 2, 4, 3, 1 }, 0)]
        [InlineData(new[] { 9, 2, 4, 3, 1 }, 1)]
        public void ArrayCount9(int[] nums, int expected)
        {
            Assert.Equal(expected, _warmup2.ArrayCount9(nums));
        }

        [Theory]
        [InlineData(new[] { 1, 2, 9, 3, 4 }, true)]
        [InlineData(new[] { 1, 2, 3, 4, 9 }, false)]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, false)]
        [InlineData(new[] { 9, 2, 3 }, true)]
        [InlineData(new[] { 1, 9, 9 }, true)]
        [InlineData(new[] { 1, 2, 3 }, false)]
        [InlineData(new[] { 1, 9 }, true)]
        [InlineData(new[] { 5, 5 }, false)]
        [InlineData(new[] { 2 }, false)]
        [InlineData(new[] { 9 }, true)]
        [InlineData(new int[] { }, false)]
        [InlineData(new[] { 3, 9, 2, 3, 3 }, true)]
        public void ArrayFront9(int[] nums, bool expected)
        {
            Assert.Equal(expected, _warmup2.ArrayFront9(nums));
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 3, 1 }, true)]
        [InlineData(new[] { 1, 1, 2, 4, 1 }, false)]
        [InlineData(new[] { 1, 1, 2, 1, 2, 3 }, true)]
        [InlineData(new[] { 1, 1, 2, 1, 2, 1 }, false)]
        [InlineData(new[] { 1, 2, 3, 1, 2, 3 }, true)]
        [InlineData(new[] { 1, 2, 3 }, true)]
        [InlineData(new[] { 1, 1, 1 }, false)]
        [InlineData(new[] { 1, 2 }, false)]
        [InlineData(new[] { 1 }, false)]
        [InlineData(new int[] { }, false)]
        public void Array123(int[] nums, bool expected)
        {
            Assert.Equal(expected, _warmup2.Array123(nums));
        }

        [Theory]
        [InlineData("xxcaazz", "xxbaaz", 3)]
        [InlineData("abc", "abc", 2)]
        [InlineData("abc", "axc", 0)]
        [InlineData("hello", "he", 1)]
        [InlineData("he", "hello", 1)]
        [InlineData("h", "hello", 0)]
        [InlineData("", "hello", 0)]
        [InlineData("aabbccdd", "abbbxxd", 1)]
        [InlineData("aaxxaaxx", "iaxxai", 3)]
        [InlineData("iaxxai", "aaxxaaxx", 3)]
        public void StringMatch(string a, string b, int expected)
        {
            Assert.Equal(expected, _warmup2.StringMatch(a, b));
        }

        [Theory]
        [InlineData("xxHxix", "xHix")]
        [InlineData("abxxxcd", "abcd")]
        [InlineData("xabxxxcdx", "xabcdx")]
        [InlineData("xKittenx", "xKittenx")]
        [InlineData("Hello", "Hello")]
        [InlineData("xx", "xx")]
        [InlineData("x", "x")]
        [InlineData("", "")]
        public void StringX(String str, string expected)
        {
            Assert.Equal(expected, _warmup2.StringX(str));
        }

        [Theory]
        [InlineData("kitten", "kien")]
        [InlineData("Chocolate", "Chole")]
        [InlineData("CodingHorror", "Congrr")]
        [InlineData("yak", "ya")]
        [InlineData("ya", "ya")]
        [InlineData("y", "y")]
        [InlineData("", "")]
        [InlineData("ThisThatTheOther", "ThThThth")]
        public void AltPairs(String str, string expected)
        {
            Assert.Equal(expected, _warmup2.AltPairs(str));
        }

        [Theory]
        [InlineData("yakpak", "pak")]
        [InlineData("pakyak", "pak")]
        [InlineData("yak123ya", "123ya")]
        [InlineData("yak", "")]
        [InlineData("yakxxxyak", "xxx")]
        [InlineData("HiyakHi", "HiHi")]
        [InlineData("xxxyakyyyakzzz", "xxxyyzzz")]
        public void StringYak(String str, string expected)
        {
            Assert.Equal(expected, _warmup2.StringYak(str));
        }

        [Theory]
        [InlineData(new[] { 6, 6, 2 }, 1)]
        [InlineData(new[] { 6, 6, 2, 6 }, 1)]
        [InlineData(new[] { 6, 7, 2, 6 }, 1)]
        [InlineData(new[] { 6, 6, 2, 6, 7 }, 2)]
        [InlineData(new[] { 1, 6, 3 }, 0)]
        [InlineData(new[] { 6, 1 }, 0)]
        [InlineData(new int[] { }, 0)]
        [InlineData(new[] { 3, 6, 7, 6 }, 1)]
        [InlineData(new[] { 3, 6, 6, 7 }, 2)]
        [InlineData(new[] { 6, 3, 6, 6 }, 1)]
        [InlineData(new[] { 6, 7, 6, 6 }, 2)]
        [InlineData(new[] { 1, 2, 3, 5, 6 }, 0)]
        [InlineData(new[] { 1, 2, 3, 6, 6 }, 1)]
        public void Array667(int[] nums, int expected)
        {
            Assert.Equal(expected, _warmup2.Array667(nums));
        }

        [Theory]
        [InlineData(new[] { 1, 1, 2, 2, 1 }, true)]
        [InlineData(new[] { 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        [InlineData(new[] { 1, 1, 2, 2, 1, 2, 1 }, true)]
        [InlineData(new[] { 1, 2, 1 }, true)]
        [InlineData(new[] { 1, 1, 1 }, false)]
        [InlineData(new[] { 1, 1 }, true)]
        [InlineData(new[] { 1 }, true)]
        [InlineData(new int[] { }, true)]
        public void NoTriples(int[] nums, bool expected)
        {
            Assert.Equal(expected, _warmup2.NoTriples(nums));
        }

        [Theory]
        [InlineData(new[] { 1, 2, 7, 1 }, true)]
        [InlineData(new[] { 1, 2, 8, 1 }, false)]
        [InlineData(new[] { 2, 7, 1 }, true)]
        [InlineData(new[] { 3, 8, 2 }, true)]
        [InlineData(new[] { 2, 7, 3 }, true)]
        [InlineData(new[] { 2, 7, 4 }, false)]
        [InlineData(new[] { 2, 7, -1 }, true)]
        [InlineData(new[] { 2, 7, -2 }, false)]
        [InlineData(new[] { 4, 5, 3, 8, 0 }, true)]
        [InlineData(new[] { 2, 7, 5, 10, 4 }, true)]
        [InlineData(new[] { 2, 7, -2, 4, 9, 3 }, true)]
        [InlineData(new[] { 2, 7, 5, 10, 1 }, false)]
        [InlineData(new[] { 2, 7, -2, 4, 10, 2 }, false)]
        [InlineData(new[] { 1, 1, 4, 9, 0 }, false)]
        [InlineData(new[] { 1, 1, 4, 9, 4, 9, 2 }, true)]
        public void Has271(int[] nums, bool expected)
        {
            Assert.Equal(expected, _warmup2.Has271(nums));
        }
    }
}
