using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task0.V9.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task0.V9.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();
            int[] array = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };

            int res = ds.GetSumEvenArrEl(array);
            Assert.AreEqual(38, res);
        }
    }
}
