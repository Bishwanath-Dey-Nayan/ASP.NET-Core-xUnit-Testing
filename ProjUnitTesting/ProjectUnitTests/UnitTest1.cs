using ProjUnitTesting.Services;
using System;
using Xunit;

namespace ProjectUnitTests
{
    public class MathsServiceTests
    {
        private MathsService _unitTesting = null;

        public MathsServiceTests()
        {
            if(_unitTesting == null)
            {
                _unitTesting = new MathsService();
            }
        }

        [Fact]
        public void Add()
        {
            double a = 5;
            double b = 3;
            double expected = 8;

            var actual = _unitTesting.Add(a, b);
            Assert.Equal(expected, actual, 0);
        }

        [Fact]
        public void Substract()
        {
            double x1 = 10;
            double x2 = 8;
            double expected = 2;
            var actual = _unitTesting.Subtract(x1, x2);
            Assert.Equal(expected, actual, 0);
        }

        [Fact(Skip = "Do not run now")]
        public void Multiply()
        {
            double x1 = 5;
            double x2 = 8;
            double expected = 40;
            var actual = _unitTesting.Multiply(x1, x2);
            Assert.Equal(expected, actual, 0);
        }

        [Theory(DisplayName = "Maths- Divided with parameters")]
        [InlineData(40, 8, 5)]
        public void Divide(double value1, double value2, double value3)
        {
            double x1 = value1;
            double x2 = value2;
            double expected = value3;
            var actual = _unitTesting.Divide(x1, x2);
            Assert.Equal(expected, actual, 0);
        }

        [Fact(DisplayName = "Maths - Divide by Zero Exception")]
        public void DivideByZeroException()
        {
            double a = 100;
            double b = 0;
            Action act = () => _unitTesting.Divide(a, b);

            Assert.Throws<DivideByZeroException>(act);
        }
    }
}
