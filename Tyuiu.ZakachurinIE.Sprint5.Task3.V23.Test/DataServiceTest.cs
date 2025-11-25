using Tyuiu.ZakachurinIE.Sprint5.Task3.V23.Lib;
using System.IO;

namespace Tyuiu.ZakachurinIE.Sprint5.Task3.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\Пользователь\\AppData\\Local\\Temp\\OutPutFileTask3.bin";
            FileInfo fileInfo = new FileInfo(path);
            bool exit = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, exit);
        }
    }
}
