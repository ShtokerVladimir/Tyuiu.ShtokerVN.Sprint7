using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.ShtokerVN.Sprint7.V2.Lib;

namespace Tyuiu.ShtokerVN.Sprint7.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string testFilePath = @"C:\Users\geroin\source\repos\Tyuiu.ShtokerVN.Sprint7\Tyuiu.ShtokerVN.Sprint7.V2\bin\Debug\Rows.csv";
            int lineCount = 0;
            using (var reader = new StreamReader(testFilePath))
            {     
                reader.ReadLine();
                {
                    lineCount++;
                }
            }
            Assert.AreEqual(1, lineCount);
        }
    }
}
