using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task5.V7.Lib;

namespace Tyuiu.TatarinovDA.Sprint5.Task5.V7.Test
{
    [TestClass]
    public class DataServiceTests
    {
        [TestMethod]
        public void Test_LoadFromDataFile_ValidData()
        {
            DataService ds = new DataService();

            string tempFilePath = Path.GetTempFileName();

            File.WriteAllText(tempFilePath, "5, 10, -3, 7");

            double result = ds.LoadFromDataFile(tempFilePath);

            Assert.AreEqual(120.0, result);

            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
        }

        [TestMethod]
        public void Test_LoadFromDataFile_Zero()
        {
            DataService ds = new DataService();
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "0, 10, 20");

            double result = ds.LoadFromDataFile(tempFilePath);

            Assert.AreEqual(1.0, result);
            File.Delete(tempFilePath);
        }

        [TestMethod]
        public void Test_LoadFromDataFile_NegativeFirstNumber()
        {
            DataService ds = new DataService();
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "-5, 10, 20");

            double result = ds.LoadFromDataFile(tempFilePath);

            Assert.AreEqual(0.0, result);
            File.Delete(tempFilePath);
        }
    }
}
