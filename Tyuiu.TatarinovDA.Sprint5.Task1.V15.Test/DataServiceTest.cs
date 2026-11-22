using System.Globalization;
using Tyuiu.TatarinovDA.Sprint5.Task1.V15.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task1.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int start = -5;
            int end = 5;
            
            string path = ds.SaveToFileTextData(start, end);
            Assert.IsNotNull(path);
            Assert.IsTrue(File.Exists(path), "Файл по указанному пути не был создан.");
            string[] lines = File.ReadAllLines(path);
            Assert.AreEqual(11, lines.Length, "Количество строк в файле не соответствует ожидаемому.");
            
            string lineForX0 = lines[5];
            string[] parts0 = lineForX0.Split('\t');
            double resultX0 = double.Parse(parts0[1],CultureInfo.InvariantCulture);
            Assert.AreEqual(-0.5, resultX0, 0.01, "Неверное значение для x = 0");
            
            string lineForX5 = lines[0];
            string[] parts5 = lineForX5.Split('\t');
            double resultX5 = double.Parse(parts5[1], CultureInfo.InvariantCulture);
            Assert.AreEqual(-36.41, resultX5, 0.01, "Неверное значение для x = -5");

            string lineForX1 = lines[6];
            string[] parts1 = lineForX1.Split('\t');
            double resultX1 = double.Parse(parts1[1], CultureInfo.InvariantCulture);
            Assert.AreEqual(9.63, resultX1, 0.01, "Неверное значение для x = 1");
        }
    }
}
