using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint6.Task0.V6.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task0.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 0.707;
            Assert.AreEqual(wait, res);
        }
    }
}
