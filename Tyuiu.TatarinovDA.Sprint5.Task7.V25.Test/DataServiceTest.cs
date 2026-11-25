using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.TatarinovDA.Sprint5.Task7.V25.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadDataAndSave()
        {
            DataService ds = new DataService();
            string tempInputPath = Path.GetTempFileName();

            string inputText = "Hello 123 мир! test test 456. Привет World.";

            string expectedText = "123 мир!  456. Привет .";

            File.WriteAllText(tempInputPath, inputText);

            string outputPath = ds.LoadDataAndSave(tempInputPath);

            Assert.IsTrue(File.Exists(outputPath), "Выходной файл не был создан.");

            string actualText = File.ReadAllText(outputPath);
            Assert.AreEqual(expectedText, actualText, "Текст в файле не совпадает с ожидаемым.");

            File.Delete(tempInputPath);
            if (File.Exists(outputPath)) File.Delete(outputPath);
        }
    }
}
