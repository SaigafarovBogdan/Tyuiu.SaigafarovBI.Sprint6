using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SaigafarovBI.Sprint6.Task3.V12.Lib
{
    public class DataService : ISprint6Task3V12
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[0, i] % 2 == 0) matrix[0, i] = 0;
            }
            return matrix;
        }
    }
}
