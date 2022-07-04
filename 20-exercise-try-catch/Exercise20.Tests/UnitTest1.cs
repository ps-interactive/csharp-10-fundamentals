using System;
using Xunit;

namespace Exercise20.Tests
{
    public class ExceptionHandlingTests
    {
        [Fact]
        public void WhenInputStringIsNotAnInteger_TheFormatExceptionValueIsReturned()
        {
            var result = Utilities.DivideValues("123", "abc");

            Assert.Equal(-1, result);
        }

        [Fact]
        public void WhenTheSecondInputParameterIs0_TheDividedByZeroExceptionValueIsReturned()
        {
            var result = Utilities.DivideValues("123", "0");

            Assert.Equal(-2, result);
        }

        [Fact]
        public void WhenAnotherExceptionOccurs_TheExceptionValueIsReturned()
        {
            var result = Utilities.DivideValues("9223372036854775900", "0");

            Assert.Equal(-3, result);
        }

        [Fact]
        public void WhenAllParametersAreValid_TheDividedResultIsReturned()
        {
            var result = Utilities.DivideValues("21", "3");

            Assert.Equal(7, result);
        }
    }
}