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
            Console.Title = "Спринт #5 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            if (!File.Exists(path))
            {
                Console.WriteLine($"Ошибка: Файл не найден по пути {path}");
                Console.WriteLine("Убедитесь, что вы создали папку DataSprint5 на диске C и скопировали туда файл.");
                return;
            }

            double result = ds.LoadFromDataFile(path);

            double roundedResult = Math.Round(result, 3);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine($"Факториал первого числа: {roundedResult}");

            Console.ReadKey();
        }
    }
}