using Microsoft.VisualStudio.TestTools.UnitTesting;
using mathsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mathsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_zero_input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void FactorialTest_one_to_seven_input()
        {
            //Arrange
            int n = 5;
            int expected = 120;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void FactorialTest_Negative_input()
        {
            //Arrange
            int n = -1;
            int expected = -9999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod()]
        public void FactorialTest_greater_than_seven()
        {
            //Arrange
            int n = 8;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}