using Xunit;

namespace Exercises.Level1.Tests
{
    public class Warmup1Theorys
    {
        private Warmup1 _warmup1 = new Warmup1();

        [Theory]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, true)]
        [InlineData(true, true, true)]
        public void SleepIn(bool weekday, bool vacation, bool expected)
        {
            Assert.Equal(expected, _warmup1.SleepIn(weekday, vacation));
        }

        [Theory]
        [InlineData(true, true, true)]
        [InlineData(false, false, true)]
        [InlineData(true, false, false)]
        [InlineData(false, true, false)]
        public void MonkeyTrouble(bool aSmile, bool bSmile, bool expected)
        {
            Assert.Equal(expected, _warmup1.MonkeyTrouble(aSmile, bSmile));
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(3, 2, 5)]
        [InlineData(2, 2, 8)]
        [InlineData(3, 3, 12)]
        [InlineData(0, 0, 0)]
        [InlineData(0, 1, 1)]
        [InlineData(3, 4, 7)]
        public void SumDouble(int a, int b, int expected)
        {
            Assert.Equal(expected, _warmup1.SumDouble(a, b));
        }

        [Theory]
        [InlineData(19, 2)]
        [InlineData(10, 11)]
        [InlineData(21, 0)]
        [InlineData(22, 2)]
        [InlineData(25, 8)]
        [InlineData(30, 18)]
        [InlineData(0, 21)]
        [InlineData(1, 20)]
        [InlineData(2, 19)]
        [InlineData(-1, 22)]
        [InlineData(-2, 23)]
        [InlineData(50, 58)]
        public void Diff21(int n, int expected)
        {
            Assert.Equal(expected, _warmup1.Diff21(n));
        }

        [Theory]
        [InlineData(true, 6, true)]
        [InlineData(true, 7, false)]
        [InlineData(false, 6, false)]
        [InlineData(true, 21, true)]
        [InlineData(false, 21, false)]
        [InlineData(false, 20, false)]
        [InlineData(true, 23, true)]
        [InlineData(false, 23, false)]
        [InlineData(true, 20, false)]
        [InlineData(false, 12, false)]
        public void ParrotTrouble(bool talking, int hour, bool expected)
        {
            Assert.Equal(expected, _warmup1.ParrotTrouble(talking, hour));
        }

        [Theory]
        [InlineData(9, 10, true)]
        [InlineData(9, 9, false)]
        [InlineData(1, 9, true)]
        [InlineData(10, 1, true)]
        [InlineData(10, 10, true)]
        [InlineData(8, 2, true)]
        [InlineData(8, 3, false)]
        [InlineData(10, 42, true)]
        [InlineData(12, -2, true)]
        public void Makes10(int a, int b, bool expected)
        {
            Assert.Equal(expected, _warmup1.Makes10(a, b));
        }

        [Theory]
        [InlineData(93, true)]
        [InlineData(90, true)]
        [InlineData(89, false)]
        [InlineData(110, true)]
        [InlineData(111, false)]
        [InlineData(121, false)]
        [InlineData(-101, false)]
        [InlineData(-209, false)]
        [InlineData(190, true)]
        [InlineData(209, true)]
        [InlineData(0, false)]
        [InlineData(-50, false)]
        [InlineData(191, true)]
        [InlineData(189, false)]
        [InlineData(200, true)]
        [InlineData(210, true)]
        [InlineData(211, false)]
        [InlineData(290, false)]
        public void NearHundred(int n, bool expected)
        {
            Assert.Equal(expected, _warmup1.NearHundred(n));
        }

        [Theory]
        [InlineData(1, -1, false, true)]
        [InlineData(-1, 1, false, true)]
        [InlineData(-4, -5, true, true)]
        [InlineData(-4, -5, false, false)]
        [InlineData(-4, 5, false, true)]
        [InlineData(-4, 5, true, false)]
        [InlineData(1, 1, false, false)]
        [InlineData(-1, -1, false, false)]
        [InlineData(1, -1, true, false)]
        [InlineData(-1, 1, true, false)]
        [InlineData(1, 1, true, false)]
        [InlineData(-1, -1, true, true)]
        [InlineData(5, -5, false, true)]
        [InlineData(-6, 6, false, true)]
        [InlineData(-5, -6, false, false)]
        [InlineData(-2, -1, false, false)]
        [InlineData(1, 2, false, false)]
        [InlineData(-5, 6, true, false)]
        [InlineData(-5, -5, true, true)]
        public void PosNeg(int a, int b, bool negative, bool expected)
        {
            Assert.Equal(expected, _warmup1.PosNeg(a, b, negative));
        }

        [Theory]
        [InlineData("candy", "not candy")]
        [InlineData("", "not ")]
        [InlineData("not bad", "not bad")]
        [InlineData("bad", "not bad")]
        [InlineData("not", "not")]
        [InlineData("is not", "not is not")]
        [InlineData("no", "not no")]
        public void NotString(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.NotString(str));
        }

        [Theory]
        [InlineData("kitten", 1, "ktten")]
        [InlineData("kitten", 0, "itten")]
        [InlineData("kitten", 4, "kittn")]
        [InlineData("Hi", 0, "i")]
        [InlineData("Hi", 1, "H")]
        [InlineData("code", 0, "ode")]
        [InlineData("code", 1, "cde")]
        [InlineData("code", 2, "coe")]
        [InlineData("code", 3, "cod")]
        [InlineData("chocolate", 8, "chocolat")]
        public void MissingChar(string str, int n, string expected)
        {
            Assert.Equal(expected, _warmup1.MissingChar(str, n));
        }

        [Theory]
        [InlineData("code", "eodc")]
        [InlineData("a", "a")]
        [InlineData("ab", "ba")]
        [InlineData("abc", "cba")]
        [InlineData("", "")]
        [InlineData("Chocolate", "ehocolatC")]
        [InlineData("aavJ", "Java")]
        [InlineData("hello", "oellh")]
        public void FrontBack(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.FrontBack(str));
        }

        [Theory]
        [InlineData("Java", "JavJavJav")]
        [InlineData("Chocolate", "ChoChoCho")]
        [InlineData("abc", "abcabcabc")]
        [InlineData("abcXYZ", "abcabcabc")]
        [InlineData("ab", "ababab")]
        [InlineData("a", "aaa")]
        [InlineData("", "")]
        public void Front3(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.Front3(str));
        }

        [Theory]
        [InlineData("cat", "tcatt")]
        [InlineData("Hello", "oHelloo")]
        [InlineData("a", "aaa")]
        [InlineData("abc", "cabcc")]
        [InlineData("read", "dreadd")]
        [InlineData("boo", "obooo")]
        public void BackAround(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.BackAround(str));
        }

        [Theory]
        [InlineData(3, true)]
        [InlineData(10, true)]
        [InlineData(8, false)]
        [InlineData(15, true)]
        [InlineData(5, true)]
        [InlineData(9, true)]
        [InlineData(4, false)]
        [InlineData(7, false)]
        [InlineData(6, true)]
        [InlineData(17, false)]
        [InlineData(18, true)]
        [InlineData(29, false)]
        [InlineData(20, true)]
        [InlineData(21, true)]
        [InlineData(22, false)]
        [InlineData(45, true)]
        [InlineData(99, true)]
        [InlineData(100, true)]
        [InlineData(101, false)]
        [InlineData(121, false)]
        [InlineData(122, false)]
        [InlineData(123, true)]
        public void Or35(int n, bool expected)
        {
            Assert.Equal(expected, _warmup1.Or35(n));
        }

        [Theory]
        [InlineData("kitten", "kikittenki")]
        [InlineData("Ha", "HaHaHa")]
        [InlineData("abc", "ababcab")]
        [InlineData("ab", "ababab")]
        [InlineData("a", "aaa")]
        [InlineData("", "")]
        [InlineData("Logic", "LoLogicLo")]
        public void Front22(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.Front22(str));
        }

        [Theory]
        [InlineData("hi there", true)]
        [InlineData("hi", true)]
        [InlineData("hello hi", false)]
        [InlineData("he", false)]
        [InlineData("h", false)]
        [InlineData("", false)]
        [InlineData("ho hi", false)]
        [InlineData("hi ho", true)]
        public void StartHi(string str, bool expected)
        {
            Assert.Equal(expected, _warmup1.StartHi(str));
        }

        [Theory]
        [InlineData(120, -1, true)]
        [InlineData(-1, 120, true)]
        [InlineData(2, 120, false)]
        [InlineData(-1, 100, false)]
        [InlineData(-2, -2, false)]
        [InlineData(120, 120, false)]
        public void IcyHot(int temp1, int temp2, bool expected)
        {
            Assert.Equal(expected, _warmup1.IcyHot(temp1, temp2));
        }

        [Theory]
        [InlineData(12, 99, true)]
        [InlineData(21, 12, true)]
        [InlineData(8, 99, false)]
        [InlineData(99, 10, true)]
        [InlineData(20, 20, true)]
        [InlineData(21, 21, false)]
        [InlineData(9, 9, false)]
        public void In1020(int a, int b, bool expected)
        {
            Assert.Equal(expected, _warmup1.In1020(a, b));
        }

        [Theory]
        [InlineData(13, 20, 10, true)]
        [InlineData(20, 19, 10, true)]
        [InlineData(20, 10, 13, true)]
        [InlineData(1, 20, 12, false)]
        [InlineData(19, 20, 12, true)]
        [InlineData(12, 20, 19, true)]
        [InlineData(12, 9, 20, false)]
        [InlineData(12, 18, 20, true)]
        [InlineData(14, 2, 20, true)]
        [InlineData(4, 2, 20, false)]
        [InlineData(11, 22, 22, false)]
        public void HasTeen(int a, int b, int c, bool expected)
        {
            Assert.Equal(expected, _warmup1.HasTeen(a, b, c));
        }

        [Theory]
        [InlineData(13, 99, true)]
        [InlineData(21, 19, true)]
        [InlineData(13, 13, false)]
        [InlineData(14, 20, true)]
        [InlineData(20, 15, true)]
        [InlineData(16, 17, false)]
        [InlineData(16, 9, true)]
        [InlineData(16, 18, false)]
        [InlineData(13, 19, false)]
        [InlineData(13, 20, true)]
        [InlineData(6, 18, true)]
        [InlineData(99, 13, true)]
        [InlineData(99, 99, false)]
        public void LoneTeen(int a, int b, bool expected)
        {
            Assert.Equal(expected, _warmup1.LoneTeen(a, b));
        }

        [Theory]
        [InlineData("adelbc", "abc")]
        [InlineData("adelHello", "aHello")]
        [InlineData("adedbc", "adedbc")]
        [InlineData("abcdel", "abcdel")]
        [InlineData("add", "add")]
        [InlineData("ad", "ad")]
        [InlineData("a", "a")]
        [InlineData("", "")]
        [InlineData("del", "del")]
        [InlineData("adel", "a")]
        [InlineData("aadelbb", "aadelbb")]
        public void DelDel(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.DelDel(str));
        }

        [Theory]
        [InlineData("mix snacks", true)]
        [InlineData("pix snacks", true)]
        [InlineData("piz snacks", false)]
        [InlineData("nix", true)]
        [InlineData("ni", false)]
        [InlineData("n", false)]
        [InlineData("", false)]
        public void MixStart(string str, bool expected)
        {
            Assert.Equal(expected, _warmup1.MixStart(str));
        }

        [Theory]
        [InlineData("ozymandias", "oz")]
        [InlineData("bzoo", "z")]
        [InlineData("oxx", "o")]
        [InlineData("oz", "oz")]
        [InlineData("ounce", "o")]
        [InlineData("o", "o")]
        [InlineData("abc", "")]
        [InlineData("", "")]
        [InlineData("zoo", "")]
        [InlineData("aztec", "z")]
        [InlineData("zzzz", "z")]
        [InlineData("oznic", "oz")]
        public void StartOz(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.StartOz(str));
        }

        [Theory]
        [InlineData(1, 2, 3, 3)]
        [InlineData(1, 3, 2, 3)]
        [InlineData(3, 2, 1, 3)]
        [InlineData(9, 3, 3, 9)]
        [InlineData(3, 9, 3, 9)]
        [InlineData(3, 3, 9, 9)]
        [InlineData(8, 2, 3, 8)]
        [InlineData(-3, -1, -2, -1)]
        [InlineData(6, 2, 5, 6)]
        [InlineData(5, 6, 2, 6)]
        [InlineData(5, 2, 6, 6)]
        public void IntMax(int a, int b, int c, int expected)
        {
            Assert.Equal(expected, _warmup1.IntMax(a, b, c));
        }

        [Theory]
        [InlineData(8, 13, 8)]
        [InlineData(13, 8, 8)]
        [InlineData(13, 7, 0)]
        [InlineData(7, 13, 0)]
        [InlineData(9, 13, 9)]
        [InlineData(10, 12, 10)]
        [InlineData(11, 10, 10)]
        [InlineData(5, 21, 5)]
        [InlineData(0, 20, 0)]
        [InlineData(10, 10, 0)]
        public void Close10(int a, int b, int expected)
        {
            Assert.Equal(expected, _warmup1.Close10(a, b));
        }

        [Theory]
        [InlineData(30, 31, true)]
        [InlineData(30, 41, false)]
        [InlineData(40, 50, true)]
        [InlineData(40, 51, false)]
        [InlineData(39, 50, false)]
        [InlineData(50, 39, false)]
        [InlineData(40, 39, true)]
        [InlineData(49, 48, true)]
        [InlineData(50, 40, true)]
        [InlineData(50, 51, false)]
        [InlineData(35, 36, true)]
        [InlineData(35, 45, false)]
        public void In3050(int a, int b, bool expected)
        {
            Assert.Equal(expected, _warmup1.In3050(a, b));
        }

        [Theory]
        [InlineData(11, 19, 19)]
        [InlineData(19, 11, 19)]
        [InlineData(11, 9, 11)]
        [InlineData(9, 21, 0)]
        [InlineData(10, 21, 10)]
        [InlineData(21, 10, 10)]
        [InlineData(9, 11, 11)]
        [InlineData(23, 10, 10)]
        [InlineData(20, 10, 20)]
        [InlineData(7, 20, 20)]
        [InlineData(17, 16, 17)]
        public void Max1020(int a, int b, int expected)
        {
            Assert.Equal(expected, _warmup1.Max1020(a, b));
        }

        [Theory]
        [InlineData("Hello", true)]
        [InlineData("Heelle", true)]
        [InlineData("Heelele", false)]
        [InlineData("Hll", false)]
        [InlineData("e", true)]
        [InlineData("", false)]
        public void StringE(string str, bool expected)
        {
            Assert.Equal(expected, _warmup1.StringE(str));
        }

        [Theory]
        [InlineData(7, 17, true)]
        [InlineData(6, 17, false)]
        [InlineData(3, 113, true)]
        [InlineData(114, 113, false)]
        [InlineData(114, 4, true)]
        [InlineData(10, 0, true)]
        [InlineData(11, 0, false)]
        public void LastDigit(int a, int b, bool expected)
        {
            Assert.Equal(expected, _warmup1.LastDigit(a, b));
        }

        [Theory]
        [InlineData("Hello", "HeLLO")]
        [InlineData("hi there", "hi thERE")]
        [InlineData("hi", "HI")]
        [InlineData("woo hoo", "woo HOO")]
        [InlineData("xyz12", "xyZ12")]
        [InlineData("x", "X")]
        [InlineData("", "")]
        public void EndUp(string str, string expected)
        {
            Assert.Equal(expected, _warmup1.EndUp(str));
        }

        [Theory]
        [InlineData("Miracle", 2, "Mrce")]
        [InlineData("abcdefg", 2, "aceg")]
        [InlineData("abcdefg", 3, "adg")]
        [InlineData("Chocolate", 3, "Cca")]
        [InlineData("Chocolates", 3, "Ccas")]
        [InlineData("Chocolates", 4, "Coe")]
        [InlineData("Chocolates", 100, "C")]
        public void EveryNth(string str, int n, string expected)
        {
            Assert.Equal(expected, _warmup1.EveryNth(str, n));
        }
    }
}
