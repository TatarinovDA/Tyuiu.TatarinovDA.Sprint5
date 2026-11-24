using System;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.TatarinovDA.Sprint5.Task2.V16.Lib
{
    public class DataService : ISprint5Task2V16
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            
            string fileContent = "";

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    
                    int value = matrix[i, j] > 0 ? 1 : 0;

                    
                    fileContent += value;

                    
                    if (j < cols - 1)
                    {
                        fileContent += ";";
                    }
                }
                
                fileContent += Environment.NewLine;
            }

            
            string tempPath = Path.GetTempPath();
            string fileName = "OutPutFileTask2.csv";
            string fullPath = Path.Combine(tempPath, fileName);

            
            File.WriteAllText(fullPath, fileContent);

            
            return fullPath;
        }
    }
}
     
