using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(0, 0, 0, 0)]
        [InlineData(-4, -2, 7, 1)]
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calc = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = calc.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(5,2,3)]         //Add test data <-------
        [InlineData(11,6,5)]
        [InlineData(42,20,22)]
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calc = new Calculator();

            //Act
            int actual = calc.Subtract(minuend, subtrhend);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(4,5,20)]            //Add test data <-------
        [InlineData(6,7,42)]
        [InlineData(15,3,45)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calc = new Calculator();

            //Act
            int actual = calc.Multiply(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8,2,4)]         //Add test data <-------
        [InlineData(10,5,2)]
        [InlineData(50,5,10)]
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calc = new Calculator();

            //Act
            int actual = calc.Divide(num1, num2);

            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
