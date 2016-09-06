using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Calculator
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(0, Calculator.Add(0, 0));
            Assert.AreEqual(104, Calculator.Add(2, 2, 100));
            Assert.AreEqual(17, Calculator.Add(2, 6, 4, 5));
        }
        [TestMethod]
        public void Subtract()
        {
            Assert.AreEqual(6, Calculator.Subtract(10, 4));
        }
        [TestMethod]
        public void Sum()
        {
            //Arrange
            int[] numbers = new int[8];
            Assert.AreEqual(0, Calculator.Sum(numbers));

            numbers[0] = 7;
            Assert.AreEqual(7, Calculator.Sum(numbers));

            numbers[0] = 7;
            numbers[1] = 11;
            Assert.AreEqual(18, Calculator.Sum(numbers));

        }
        [TestMethod]
        public void Multiply()
        {
            Assert.AreEqual(24, Calculator.Multiply(2,3,4));
            Assert.AreEqual(10000, Calculator.Multiply(10, 10, 10, 10));
        }
        [TestMethod]
        public void Power()
        {
            Assert.AreEqual(10000, Calculator.Power(10, 4));
            Assert.AreEqual(64, Calculator.Power(2, 6));
        }
        [TestMethod]
        public void Factorial()
        {
            Assert.AreEqual(120, Calculator.Factorial(5));
        }
    }
}
