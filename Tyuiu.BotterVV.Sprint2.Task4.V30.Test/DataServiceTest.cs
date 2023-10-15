using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint2.Task4.V30.Lib;

namespace Tyuiu.BotterVV.Sprint2.Task4.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds1 = new DataService();
            double x = 10;
            double y = 5;
            double res = ds1.Calculate(x, y);
            double wait = 8038.679;

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds2 = new DataService();
            double x = 2;
            double y = 5;
            double res = ds2.Calculate(x, y);
            double wait = 5.5;

            Assert.AreEqual(wait, res);
        }
    }
}
