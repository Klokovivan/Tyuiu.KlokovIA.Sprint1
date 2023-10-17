using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint1.Task0.V13.Lib;

namespace Tyuiu.KlokovIA.Sprint1.Task0.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(1, res);
        }
    }
}
