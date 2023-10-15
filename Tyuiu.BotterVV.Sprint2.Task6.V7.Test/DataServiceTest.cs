using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint2.Task6.V7.Lib;

namespace Tyuiu.BotterVV.Sprint2.Task6.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindMonthName()
        {
            DataService ds = new DataService();
            int startYear, n;
            startYear = 1990;
            n = 3;
            string res = ds.FindMonthName(startYear, n);
            string wait = "Апрель";

            Assert.AreEqual(wait, res);

        }
    }
}
