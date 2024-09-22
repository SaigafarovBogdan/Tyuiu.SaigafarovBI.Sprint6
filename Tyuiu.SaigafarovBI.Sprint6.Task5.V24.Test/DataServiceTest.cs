using Tyuiu.SaigafarovBI.Sprint6.Task5.V24.Lib;
namespace Tyuiu.SaigafarovBI.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.SaigafarovBI.Sprint6\Tyuiu.SaigafarovBI.Sprint6.Task5.V24\bin\Debug\net8.0-windows\InPutFileTask5.txt";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);

        }
    }
}