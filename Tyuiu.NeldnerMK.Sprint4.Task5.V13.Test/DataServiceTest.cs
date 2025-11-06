using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task5.V13.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task5.V13.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int[,] array = {
                { 1, -1, 2 },
                { -2, 0, 3 },
                { 4, -3, 5 }
             };

            int[,] array2 = {
                { 1, 0, 2 },
                { 0, 0, 3 },
                { 4, 0, 5 }
             };

            int[,] res = ds.Calculate(array);

            CollectionAssert.AreEqual(array2, res);
        }
    }
}