using Tyuiu.SaigafarovBI.Sprint6.Task1.V20.Lib;

namespace Tyuiu.SaigafarovBI.Sprint6.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            //CollectionAssert.AreEqual(0.722, dataService.GetMassFunction(-5,5));
        }
    }
}