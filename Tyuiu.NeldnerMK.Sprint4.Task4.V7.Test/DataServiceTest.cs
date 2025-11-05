using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics.CodeAnalysis;
using Tyuiu.NeldnerMK.Sprint4.Task4.V7.Lib;

namespace Tyuiu.NeldnerMK.Sprint4.Task4.V7.Test
{
    [TestClass]

    public class DataServiсeTest
    {
        [TestMethod]
        public void ValidGetCompare()
        {
            DataService ds = new DataService();

            int[,] matrix = { { 4, 3, 6, 5, 5
                },

                            { 3, 4, 4, 6, 4
                },

                            { 6, 4, 6, 4, 5
                },

                            { 5, 4, 4, 4, 5
                },

                            { 3, 5, 6, 4, 6
                }
            };

            int res = ds.Calculate(matrix);
            Assert.AreEqual(39, res);
        }
    }
}

