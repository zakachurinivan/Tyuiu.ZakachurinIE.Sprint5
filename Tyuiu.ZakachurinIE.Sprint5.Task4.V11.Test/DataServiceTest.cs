using Tyuiu.ZakachurinIE.Sprint5.Task4.V11.Lib;

namespace Tyuiu.ZakachurinIE.Sprint5.Task4.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\Пользователь\DataSprint5\InPutDataFileTask4V11.txt";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
