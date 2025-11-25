using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakachurinIE.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11

    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = double.Parse(strX, CultureInfo.InvariantCulture);
            double res = Math.Round(Math.Sin(x) + Math.Pow(x,2)/2, 3);
            return res;
        }
    }
}
