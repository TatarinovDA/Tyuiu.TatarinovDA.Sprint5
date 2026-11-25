using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task4.V22.Lib;
// 
namespace Tyuiu.TatarinovDA.Sprint5.Task4.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string directory = @"C:\DataSprint5";
            string fileName = "InPutDataFileTask4V0.txt";
            string path = Path.Combine(directory, fileName);

            Console.WriteLine($"Путь к файлу: {path}");

            if (!File.Exists(path))
            {
                Console.WriteLine("ОШИБКА: Файл не найден! Создайте папку C:\\DataSprint5 и положите туда файл.");
                Console.ReadKey();
                return;
            }

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Результат вычислений: {res}");

            Console.ReadKey();
        }
    }
}