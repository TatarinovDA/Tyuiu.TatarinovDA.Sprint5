using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string content = File.ReadAllText(path);

            string result = Regex.Replace(content, @"\s*\b[a-zA-Z]+\b\s*", " ").Trim();

            string tempPath = Path.GetTempPath();
            string outFileName = "OutPutDataFileTask7V25.txt";
            string outFilePath = Path.Combine(tempPath, outFileName);

            File.WriteAllText(outFilePath, result);

            return outFilePath;
        }
    }
}