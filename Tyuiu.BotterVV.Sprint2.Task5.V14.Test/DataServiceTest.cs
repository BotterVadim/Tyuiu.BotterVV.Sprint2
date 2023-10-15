using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.BotterVV.Sprint2.Task5.V14.Lib;

namespace Tyuiu.BotterVV.Sprint2.Task5.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDayName()
        {
            DataService ds = new DataService();
            int k = 21;
            int d = (k) % 7;
            string res = ds.FindDayName(k, d);
            string wait = "Воскресенье";

            Assert.AreEqual(wait, res);
        }
    }
}
