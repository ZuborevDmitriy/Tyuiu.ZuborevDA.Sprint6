using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.ZuborevDA.Sprint6.Task5.V25.Lib;

namespace Tyuiu.ZuborevDA.Sprint6.Task5.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = @"C:\DataSprint6\InPutFileTask5V25.txt";

            double[] res = ds.LoadFromDataFile(path);

            int len = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            int numb = 0;
            for (int i = 0; i < len - 1; i++)
            {
                if (i != 0)
                {
                    numb++;
                }
            }

            double[] valueWaitArray;
            valueWaitArray = new double[numb];

            valueWaitArray[0] = -17;
            valueWaitArray[1] = 12;
            valueWaitArray[2] = -14.32;
            valueWaitArray[3] = 5;
            valueWaitArray[4] = -7.84;
            valueWaitArray[5] = 12.89;
            valueWaitArray[6] = -1.57;
            valueWaitArray[7] = -3.64;
            valueWaitArray[8] = -13.26;
            valueWaitArray[9] = -8.91;
            valueWaitArray[10] = -17.77;
            valueWaitArray[11] = 35;
            valueWaitArray[12] = -9;
            valueWaitArray[13] = 13.83;
            valueWaitArray[14] = 12.76;
            valueWaitArray[15] = 8.86;
            valueWaitArray[16] = -1.49;
            valueWaitArray[17] = -7;

            CollectionAssert.AreEqual(valueWaitArray, res);

        }
    }
}
