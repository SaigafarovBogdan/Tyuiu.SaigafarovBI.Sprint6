using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.SaigafarovBI.Sprint6.Task1.V20.Lib
{
    public class DataService : ISprint6Task1V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] values = new double[stopValue - startValue + 1];
            int index = 0;

            for(int i = startValue;i <= stopValue;i++)
            {
                if (Math.Cos(i) - 2 * i == 0)
                {
                    values[index] = 0;
                    index++;
                    continue;
                }
                values[index] = Math.Round((2*i - 3)/ (Math.Cos(i) - 2*i) +5*i - Math.Sin(i),2);
                index++;
            }
            return values;
        }
    }
}
