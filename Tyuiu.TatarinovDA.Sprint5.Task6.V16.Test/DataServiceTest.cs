using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TatarinovDA.Sprint5.Task6.V16.Lib;
namespace Tyuiu.TatarinovDA.Sprint5.Task6.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void Test_LoadFromDataFile_ValidData()
        {
            DataService ds = new DataService();
            string tempFilePath = Path.GetTempFileName();

            File.WriteAllText(tempFilePath, "Hello, world! Привет, мир. test 123.");

            int result = ds.LoadFromDataFile(tempFilePath);

            Assert.AreEqual(3, result);

            if (File.Exists(tempFilePath))
            {
                File.Delete(tempFilePath);
            }
        }

        [TestMethod]
        public void Test_LoadFromDataFile_EmptyFile()
        {
            DataService ds = new DataService();
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllText(tempFilePath, "");

            int result = ds.LoadFromDataFile(tempFilePath);

            Assert.AreEqual(0, result);
            File.Delete(tempFilePath);
        }
    }
}
