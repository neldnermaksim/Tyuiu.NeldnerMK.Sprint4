using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task2.V20.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task2.V20.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int[] numsArry = { 2,4,5,7,8 };

            int res = ds.Calculate(numsArry);
            Assert.AreEqual(14, res);
        }
    }
}
