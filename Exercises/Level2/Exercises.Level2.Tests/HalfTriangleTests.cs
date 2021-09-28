using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Exercises.Level2.Tests
{
    public class HalfTriangleTests
    {
        private readonly HalfTriangle _halfTriangle = new HalfTriangle();

        [Fact]
        public void HalfTriangle1()
        {
            string[] expected1 = new string[]
            {
                "*"
            };

            Assert.Equal(expected1, _halfTriangle.GetHalfTriangle(1));
        }

        [Fact]
        public void HalfTriangle3()
        {
            string[] expected = new string[]
            {
                "*",
                "***",
                "*****"
            };

            Assert.Equal(expected, _halfTriangle.GetHalfTriangle(3));
        }

        [Fact]
        public void HalfTriangle4()
        {
            string[] expected = new string[]
            {
                "*",
                "***",
                "*****",
                "*******"
            };

            Assert.Equal(expected, _halfTriangle.GetHalfTriangle(4));
        }

        [Fact]
        public void HalfTriangle5()
        {
            string[] expected = new string[]
            {
                "*",
                "***",
                "*****",
                "*******",
                "*********"
            };

            Assert.Equal(expected, _halfTriangle.GetHalfTriangle(5));
        }

        [Fact]
        public void HalfTriangle10()
        {
            string[] expected = new string[]
            {
                "*",
                "***",
                "*****",
                "*******",
                "*********",
                "***********",
                "*************",
                "***************",
                "*****************",
                "*******************",
            };

            Assert.Equal(expected, _halfTriangle.GetHalfTriangle(10));
        }
    }
}
