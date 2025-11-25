using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakachurinIE.Sprint5.Task5.V20.Lib
{
    public class DataService : ISprint5Task5V20
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    int k = 0;
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if ((double.Parse(numbers[i], CultureInfo.InvariantCulture) > -10) && (double.Parse(numbers[i], CultureInfo.InvariantCulture) < 10))
                        {
                            res += double.Parse(numbers[i], CultureInfo.InvariantCulture);
                            k += 1;
                        }
                        
                    }
                    res = res / k;
                }
                
            }
            return Math.Round(res,3);
        }
    }
}
