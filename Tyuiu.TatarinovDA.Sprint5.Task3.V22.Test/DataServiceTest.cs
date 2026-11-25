using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task3.V22.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task3.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            double expectedValue = -0.444;

            string path = ds.SaveToFileTextData(x);

            Assert.IsNotNull(path);
            Assert.IsTrue(path.Length > 0);

            Assert.IsTrue(File.Exists(path), "Файл не был создан");

            double actualValue;
            using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.Open)))
            {
                actualValue = reader.ReadDouble();
            }

            Assert.AreEqual(expectedValue, actualValue, 0.001);
        }
    }
}
