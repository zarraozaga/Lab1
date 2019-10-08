using Lab1;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        [TestCase(0, 0)]
        public void Divide_WithNegativeInputs_ResultThrowArgumentException(int a, int b)
        {
            Assert.That(() => _calculator.Divide(a, b), Is.EqualTo(1));
        }


        [Test]
        public void Factorial_Numbers_EqualTo()
        {
            // Act
            int result = _calculator.Factorial(4);
            int zeroResult = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(24));
            Assert.That(zeroResult, Is.EqualTo(1));
        }

        [Test]
        [TestCase(-1)]
        public void Factorial_WithNegativeInputs_ResultThrowArgumentException(int a)
        {
            Assert.That(() => _calculator.Factorial(a), Throws.ArgumentException);
        }

        [Test]
        public void Area_of_triangle_Equals_to()
        {
            double triangleA = _calculator.TriangleArea(3, 4);
            double triangleB = _calculator.TriangleArea(0, 0);
            double triangleC = _calculator.TriangleArea(9, 9);

            Assert.That(triangleA, Is.EqualTo(6));
        }

        [Test]
        public void Triangle_with_negative_inputs()
        {
            Assert.That(() => _calculator.TriangleArea(-1, -1), Throws.ArgumentException);
        }

    }
}