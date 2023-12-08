using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ZuborevDA.Sprint6.Task6.V22.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task6.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string path = @"C:\DataSprint6\InPutFileTask6V22.txt";
            string res = ds.CollectTextFromFile(path);
            string wait = "MLgyapd kEPQzl IOuDWll TMRyztkPxzEVkcarVMlQ unwTmf";
            Assert.AreEqual(wait, res);
        }
    }
}
