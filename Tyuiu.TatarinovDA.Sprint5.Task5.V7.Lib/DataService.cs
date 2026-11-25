using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string text = File.ReadAllText(path);

            string[] parts = text.Split(new char[] { ' ', ',', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length == 0) return 0;

            if (int.TryParse(parts[0].Trim(), out int firstNumber))
            {

                if (firstNumber < 0) return 0;

                double factorial = 1;
                for (int i = 1; i <= firstNumber; i++)
                {
                    factorial *= i;
                }

                return factorial;
            }

            return 0; 
        }
    }
}