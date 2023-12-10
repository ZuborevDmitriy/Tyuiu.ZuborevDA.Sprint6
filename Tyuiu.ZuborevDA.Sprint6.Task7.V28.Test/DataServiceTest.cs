using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZuborevDA.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task7.V28.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask7V28.csv";
            int[,] res = ds.GetMatrix(path);
            int[,] waitArray = new int[10, 10] { { 12, 7, 0, -9, 4, 5, 7, -10, -12, -5 },
                                                 { 10, 16, 2, -9, -7, 5, -14, -9, -9, 2 },
                                                 { 17, -9, 20, -19, -14, -12, 12, -19, -9, -13 },
                                                 { 19, 6, -16, -15, 3, 20, 5, -1, -17, 8 },
                                                 { - 12, 17, 18, 8, -16, -20, -3, -18, 16, 16 },
                                                 { 13, -6, -9, 3, 20, -5, 6, 16, -2, -7 },
                                                 { 19, -3, 8, -17, 7, 1, 13, -7, 17, 0 },
                                                 { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                                                 { 3, 8, -13, -19, 11, 20, 14, -13, 0, 16 },
                                                 { 6, 3, 7, 7, 5, -6, -18, -14, -13, 13 } };
            CollectionAssert.AreEqual(waitArray, res);

        }
    }
}

