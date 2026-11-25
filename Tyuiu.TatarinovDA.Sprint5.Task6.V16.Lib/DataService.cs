using System;
using System.IO;
using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            string content = File.ReadAllText(path);
            MatchCollection matches = Regex.Matches(content, @"[a-zA-Z]+");
            return matches.Count;
        }
    }
}
