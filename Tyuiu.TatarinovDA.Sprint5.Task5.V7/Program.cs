using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task5.V7.Lib;
// 
namespace Tyuiu.TatarinovDA.Sprint5.Task5.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            string path = Path.Combine("C:", "DataSprint5", "InPutDataFileTask5V7.txt");

            if (!File.Exists(path))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {path}");
                Console.WriteLine("Убедитесь, что вы создали папку DataSprint5 на диске C и скопировали туда файл.");
                return;
            }

            double result = ds.LoadFromDataFile(path);

            double roundedResult = Math.Round(result, 3);

            Console.WriteLine($"Факториал первого числа: {roundedResult}");

            Console.ReadKey();
        }
    }
}