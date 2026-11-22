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
            Assert.IsTrue(File.Exists(path), "Файл по указанному пути не был создан.");
            string[] lines = File.ReadAllText(path).Split(new[] { '\n' }, System.StringSplitOptions.RemoveEmptyEntries);
            Assert.AreEqual(11, lines.Length, "Количество строк в файле не соответствует ожидаемому.");
            
            
            double resultX0 = double.Parse(lines[5],CultureInfo.GetCultureInfo("ru-RU"));
            Assert.AreEqual(-0.5, resultX0, 0.01, "Неверное значение для x = 0");
            
            
            double resultX5 = double.Parse(lines[0], CultureInfo.GetCultureInfo("ru-RU"));
            Assert.AreEqual(-36.41, resultX5, 0.01, "Неверное значение для x = -5");

            
        }
    }
}
