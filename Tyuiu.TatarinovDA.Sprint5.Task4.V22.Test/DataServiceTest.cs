using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task4.V22.Lib;

namespace Tyuiu.TatarinovDA.Sprint5.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();

            double testValue = 2.0;
            File.WriteAllText(path, testValue.ToString());

            double expected = Math.Round(Math.Pow(testValue, 3) * Math.Sin(testValue) - 4 * testValue, 3);

            double actual = ds.LoadFromDataFile(path);

            Assert.AreEqual(expected, actual);

            File.Delete(path);
        }
    }
}
