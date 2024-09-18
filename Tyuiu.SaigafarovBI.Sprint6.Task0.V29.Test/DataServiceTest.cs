using Tyuiu.SaigafarovBI.Sprint6.Task0.V29.Lib;

namespace Tyuiu.SaigafarovBI.Sprint6.Task0.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(0.722, dataService.Calculate(3));
        }
    }
}