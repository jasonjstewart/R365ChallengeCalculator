using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge_Calculator;
using System;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            string input = "//[##][$$]\\n1$$2,3,4";
            string expected = "1+2+3+4=10";
            Console.WriteLine(input);
            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            string input = "1,2,3,4";
            string expected = "1+2+3+4=10";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            string input = "//[##][$$]\\n1$$2\\n3##4,5";
            string expected = "1+2+3+4+5=15";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            string input = "//[##][$$]\\n1$$r3\\n3##tt,5";
            string expected = "1+0+3+0+5=9";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            string input = "//[##]\\n1$$r3\\n3##tt,5";
            string expected = "0+3+0+5=8";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            string input = "//\\ntt,5,r4,4";
            string expected = "0+5+0+4=9";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            string input = "//[*][!!][r9r]\\n11r9r22*hh*33!!44";
            string expected = "11+22+0+33+44=110";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod8()
        {
            // Arrange
            string input = "//[***]\\n11***22***33";
            string expected = "11+22+33=66";

            // Act
            string actual = Program.Calculator(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }

    }
}
