using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task7.V17.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task7.V17.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            string str = "753159864";

            int n = 3;
            int m = 3;

            int res = ds.Calculate(n, m, str);

            Assert.AreEqual(3, res);
        }
    }
}
