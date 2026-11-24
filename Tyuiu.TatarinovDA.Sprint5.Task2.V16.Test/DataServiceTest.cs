using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task2.V16.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task2.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 2, -4, -8 },
                { 3, -7, -2 },
                { 3, 8, 6 }
            };

            string path = ds.SaveToFileTextData(matrix);

            bool fileExists = File.Exists(path);
            Assert.IsTrue(fileExists, "Файл не был создан по указанному пути.");

            string[] lines = File.ReadAllLines(path);

            Assert.AreEqual("1;0;0", lines[0]);
            Assert.AreEqual("1;0;0", lines[1]);
            Assert.AreEqual("1;1;1", lines[2]);
        }
    }
}
