using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZuborevDA.Sprint6.Task7.V28.Lib
{
    public class DataService : ISprint6Task7V28
    {
        public int[,] GetMatrix(string path)
        {
            string[] str = File.ReadAllLines(path);

            int rows = str[0].Split(';').Length;
            int columns = str.Length;

            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < str.Length; i++)
            {
                string strIndexI = str[i];
                string[] strArr = strIndexI.Split(';');
                for (int c = 0; c < str.Length; c++)
                {
                    matrix[i, c] = Convert.ToInt32(strArr[c]);
                }
            }

            int xRow = 7;
            for (int r = xRow; r <= xRow; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (matrix[r, c] != 13)
                    {
                        matrix[r, c] = 0;
                    }
                }
            }
            return matrix;
        }
    }
}
