using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingLib.Math;

namespace UnitTesting
{
    public class PractWork6Tests
    {
        public class LogTest
        {
            private readonly BasicCalc _calculator;
            public LogTest()
            {
                _calculator = new BasicCalc();
            }
            [Fact]
            public void Log_FindNumberLogarithm()
            {
                double result = _calculator.Log(9, 3);
                Assert.Equal(2, result);
            }

            [Theory]
            [InlineData(8, 2, 3)]
            [InlineData(25, 5, 2)]
            [InlineData(144, 12, 2)]

            public void Log_Theory(int a, int b, int expectedResult)
            {
                double result = _calculator.Log(a, b);
                Assert.Equal(expectedResult, result);

            }
            [Fact]
            public void Log_ShouldThrow()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.Log(0, 0));
            }
        }

        public class IsPerfectNumberTest
        {
            private readonly BasicCalc _calculator;

            public IsPerfectNumberTest()
            {
                _calculator = new BasicCalc();
            }


            [Fact]
            public void IsPerfectNumber_ShouldReturnTrue()
            {
                bool result = _calculator.IsPerfectNumber(6);
                Assert.True(result);
            }

            [Fact]
            public void IsPerfectNumber_ShouldReturnFalse()
            {
                bool result = _calculator.IsPerfectNumber(5);
                Assert.False(result);
            }


            [Theory]
            [InlineData(28)]
            [InlineData(496)]
            public void IsPerfectNumber_Theory(int a)
            {
                bool result = _calculator.IsPerfectNumber(a);
                Assert.True(result);
            }

            [Fact]
            public void Divide_ShouldThrowDivideByZeroException()
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => _calculator.IsPerfectNumber(-2));
            }
        }
    }
}
