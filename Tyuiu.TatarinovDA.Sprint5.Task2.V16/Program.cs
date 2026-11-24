using System;
using Tyuiu.TatarinovDA.Sprint5.Task2.V16.Lib;
// 
namespace Tyuiu.TatarinovDA.Sprint5.Task2.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.Title = "Спринт #5 | Выполнил: Татаринов Д. А. | ИСТНб-26-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Татаринов Данил Андреевич | ИСТНб-26-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 3, результат сохранить    *");
            Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль.              *");
            Console.WriteLine("* Округлить до трёх знаков после запятой.                                 *");




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            int[,] matrix = new int[3, 3];
            Console.WriteLine("Введите элементы массива 3x3 (по 3 числа в строке):");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Строка {i + 1}: ");
                string input = Console.ReadLine();
                
                string[] parts = input.Split(new char[] { ' ', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < 3; j++)
                {
                    matrix[i, j] = Convert.ToInt32(parts[j]);
                }
            }

            
            string path = ds.SaveToFileTextData(matrix);

            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write((matrix[i, j] > 0 ? 1 : 0) + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\nФайл успешно сохранен по пути: {path}");

            Console.WriteLine("***************************************************************************");

            Console.ReadKey();
        }
    }
}
