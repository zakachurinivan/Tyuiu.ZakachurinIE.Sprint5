using Tyuiu.ZakachurinIE.Sprint5.Task2.V12.Lib;
using System.IO;


namespace Tyuiu.ZakachurinIE.Sprint5.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = "C:\\Users\\Пользователь\\AppData\\Local\\Temp\\OutPutFileTask2.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool exit = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(true, exit);
        }
    }
}
