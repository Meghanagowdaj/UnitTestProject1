using CalculationLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Calculation calc;
        public UnitTest1()
        {
            calc = new Calculation();
        }
        [TestMethod]
        public void TestMethod1()
        {   int num1 = 45;
            int num2 = 45;

            Assert.AreEqual(num1, num2);
        }
        [TestMethod]
        public void AddTest()
        {   double num1 = 5;
            double num2 = 10;
            double result = 15;

            Assert.AreEqual(result, calc.Add(num1, num2));
        }
        [TestMethod]
        public void MultiTest()
        {   
            double num1 = 5;
            double num2 = 10;
            double result = 50;
            Assert.AreEqual(result, calc.Multi(num1, num2));

        }
        [TestMethod]
        public void DivTest()
        {   double num1 = 10;
            double num2 = 5;
            double result = 2;

            Assert.AreEqual(result, calc.Div(num1, num2));
        }
        [TestMethod]
        public void SubTest()
        {   double num1 = 50;
            double num2 = 10;
            double result = 40;

            Assert.AreEqual(result, calc.Sub(num1, num2));
        }
    }
}