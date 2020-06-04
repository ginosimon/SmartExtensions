using System;
using Xunit;

namespace SmartExtensions.Test
{
    public class ShortExtensionsTest
    {
        [Fact]
        public void Pow_ShortBaseBytePow_CorrectResult()
        {
            short baseNum = 129;
            byte pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_ShortBaseUShortPow_CorrectResult()
        {
            short baseNum = 129;
            ushort pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void Pow_ShortBaseIntPow_CorrectResult()
        {
            short baseNum = 129;
            uint pow = 5;
            Assert.Equal(Math.Pow(baseNum, pow), baseNum.Pow(pow));
        }

        [Fact]
        public void GetPercentage_Short_Int()
        {
            short num = 100;
            Assert.Equal(33.0M, num.GetPercentage((int)33));
        }

        [Fact]
        public void GetPercentage_Short_Float()
        {
            short num = 100;
            Assert.Equal(33.0M, num.GetPercentage((float)33.0F));
        }

        [Fact]
        public void GetPercentage_Short_Double()
        {
            short num = 100;
            Assert.Equal(33.0M, num.GetPercentage((double)33.0));
        }

        [Fact]
        public void GetPercentage_Short_Long()
        {
            short num = 100;
            Assert.Equal(33.0M, num.GetPercentage((long)33));
        }
    }
}