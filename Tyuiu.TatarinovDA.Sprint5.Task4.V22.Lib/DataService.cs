using System;
using System.IO;
using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task4.V22.Lib
{
    public class DataService : ISprint5Task4V22
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);

            double x = double.Parse(strX.Replace(',', '.'), CultureInfo.InvariantCulture);

            double y = Math.Pow(x, 3) * Math.Sin(x) - 4 * x;

            return Math.Round(y, 3);
        }
    }
}
