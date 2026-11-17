using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task0.V6.Lib
{
    public class DataService : ISprint5Task0V6
    {
        public string SaveToFileTextData(int x)
        {
            double result = x / Math.Sqrt(Math.Pow(x, 2) + x);
            double roundedResult = Math.Round(result, 3);
            string fileName = "OutPutFileTask0.txt";
            string path = Path.Combine(Path.GetTempPath(),fileName);
            File.WriteAllText(path, roundedResult.ToString());
            return path;
        }
    }
}
