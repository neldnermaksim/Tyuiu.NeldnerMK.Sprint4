using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task1.V11.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task1.V11.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int[] numsArry = { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };

            int res = ds.Calculate(numsArry);
            Assert.AreEqual(32, res);
        }
    }
}
