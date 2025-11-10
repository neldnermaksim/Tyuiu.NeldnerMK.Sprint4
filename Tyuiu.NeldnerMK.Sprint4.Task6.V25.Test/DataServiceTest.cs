using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task6.V25.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task6.V25.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            string[] matrix = { "Теннис", "Футбол", "Крикет", "Баскетбол", "Бейсбол", "Регби", "Хоккей" };
            int res = ds.Calculate(matrix);

            Assert.AreEqual(2, res);
        }
    }
}
