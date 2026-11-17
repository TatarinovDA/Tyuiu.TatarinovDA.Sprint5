using Tyuiu.TatarinovDA.Sprint5.Task0.V6.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;
            string path = ds.SaveToFileTextData(x);
            bool fileExists = File.Exists(path);
            Assert.AreEqual(true, fileExists, "Файл не был создан!");
            string content = File.ReadAllText(path).Trim();
            string expectedResult = "0.866";
            bool isResultCorrect = (content == "0.866" || content == "0,866");
            Assert.AreEqual(true, isResultCorrect, "Значение в файле неверное!");
        }
    }
}
