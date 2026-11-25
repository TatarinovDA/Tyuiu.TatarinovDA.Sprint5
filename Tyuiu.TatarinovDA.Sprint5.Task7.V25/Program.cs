using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task7.V25.Lib;
// 
namespace Tyuiu.TatarinovDA.Sprint5.Task7.V25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string inputPath = @"C:\DataSprint5\InPutDataFileTask7V25.txt";

            Console.Title = "Спринт #5 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #25                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            if (!File.Exists(inputPath))
            {
                Console.WriteLine($"Ошибка: Файл по пути {inputPath} не найден.");
                Console.WriteLine("Убедитесь, что вы создали папку и скопировали туда файл.");
                return;
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string resultPath = ds.LoadDataAndSave(inputPath);

            Console.WriteLine($"Обработка завершена. Результат сохранен по пути: {resultPath}");

            Console.ReadKey();
        }
    }
}