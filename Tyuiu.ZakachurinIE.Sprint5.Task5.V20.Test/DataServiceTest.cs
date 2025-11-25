using Tyuiu.ZakachurinIE.Sprint5.Task5.V20.Lib;
using System.IO;

namespace Tyuiu.ZakachurinIE.Sprint5.Task5.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\DataSprint5\InPutDataFileTask5V20.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
