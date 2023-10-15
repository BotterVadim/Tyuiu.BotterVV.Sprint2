using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint2.Task3.V7.Lib;

namespace Tyuiu.BotterVV.Sprint2.Task3.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds1 = new DataService();
            double x = 2;
            double res = ds1.Calculate(x);
            double wait = 50;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds2 = new DataService();
            double x = 0;
            double res = ds2.Calculate(x);
            double wait = 16.773;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds3 = new DataService();
            double x = 1;
            double res = ds3.Calculate(x);
            double wait = 64;
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds4 = new DataService();
            double x = -12;
            double res = ds4.Calculate(x);
            double wait = 20736.25;
            Assert.AreEqual(wait, res);
        }
    }
}
