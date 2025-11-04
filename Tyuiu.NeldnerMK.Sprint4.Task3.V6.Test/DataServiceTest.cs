using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task3.V6.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task3.V6.Test
{
    [TestClass]

    public class DataServiseTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int[,] array = { { 8, 8, 3, 4, 5 }, { 8, 6, 6, 4, 6 }, { 3, 6, 5, 3, 4 }, { 5, 6, 3, 7, 5 }, { 7, 8, 5, 6, 6 } };

            int res = ds.Calculate(array);
            Assert.AreEqual(8, res);
        }
    }
}
