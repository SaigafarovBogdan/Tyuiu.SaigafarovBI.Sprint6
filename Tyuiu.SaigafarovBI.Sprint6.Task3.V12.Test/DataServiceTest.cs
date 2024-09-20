using Tyuiu.SaigafarovBI.Sprint6.Task3.V12.Lib;

namespace Tyuiu.SaigafarovBI.Sprint6.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            int[,] matrix = new int[,]
            {
                {-6, -13,  -1,  -7,  10},

                {14, -18,  18,   1,  11},

                {-2, -17, -15, -10,  -8},

                {19,  -4,  -6, -11,   8},

                {-17,  17,  14,  13,  19}
            };
            int[,] wait = new int[,]
            {
                {0, -13,  -1,  -7,  0},

                {14, -18,  18,   1,  11},

                {-2, -17, -15, -10,  -8},

                {19,  -4,  -6, -11,   8},

                {-17,  17,  14,  13,  19}
            };
            CollectionAssert.AreEqual(dataService.Calculate(matrix),wait);
        }
    }
}