using Tyuiu.SaigafarovBI.Sprint6.Task5.V24.Lib;
namespace Tyuiu.SaigafarovBI.Sprint6.Task5.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\User\AppData\Local\Temp\tmp5iyncx.tmp";
            FileInfo file = new FileInfo(path);
            Assert.AreEqual(true, file.Exists);

        }
    }
}