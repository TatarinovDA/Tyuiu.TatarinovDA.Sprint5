using System.Xml;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int x = startValue; x <= stopValue; x++)
                {
                    double denominator = x - 0.4;
                    double result = 0;
                    if (denominator == 0)
                    {
                        result = 0;
                    }
                    else
                    {
                        result = Math.Cos(x) / denominator + Math.Sin(x) * 8 * x + 2;
                    }
                    if (double.IsInfinity(result) || double.IsNaN(result))
                    {
                        result = 0;
                    }
                    result = Math.Round(result, 2);
                    writer.WriteLine($"{x}\t{result.ToString(System.Globalization.CultureInfo.InvariantCulture)}");
                }
            }
            return path;
        }
    }
}
