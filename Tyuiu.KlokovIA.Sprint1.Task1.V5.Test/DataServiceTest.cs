using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint1.Task1.V5.Lib;

namespace Tyuiu.KlokovIA.Sprint1.Task1.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 3.0;
            double y = 9.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(14, res);
        }
    }
}
