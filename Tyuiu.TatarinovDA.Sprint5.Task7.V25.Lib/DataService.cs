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

            string result = Regex.Replace(content, "[a-zA-Z]+", "").Trim();
            result = Regex.Replace(result, @" +([.,!?])", "$1");
            result = Regex.Replace(result, @" {2,}", " ");

            string outFilePath = Path.Combine(Path.GetTempPath(), "OutPutDataFileTask7V25.txt");

            File.WriteAllText(outFilePath, result);

            return outFilePath;
        }
    }
}