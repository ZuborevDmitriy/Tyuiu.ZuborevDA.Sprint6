using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZuborevDA.Sprint6.Task6.V22.Lib
{
    public class DataService : ISprint6Task6V22
    {
        public string CollectTextFromFile(string path)
        {
            string result = "";
            string trimmedResult = "";

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split();
                    result += words[0] + " ";
                    char[] End = {' '};
                    trimmedResult = result.Trim(End);
                }
            }
            return trimmedResult;
        }
    }
}
