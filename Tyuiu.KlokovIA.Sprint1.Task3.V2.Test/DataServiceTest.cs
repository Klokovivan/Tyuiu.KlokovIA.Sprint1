using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KlokovIA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.KlokovIA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double priceNotebook = 2;
            int amountNotebook = 6;
            double pricePencil = 3;
            int amountPencil = 8;


            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(36, res);
        }
    }
}
