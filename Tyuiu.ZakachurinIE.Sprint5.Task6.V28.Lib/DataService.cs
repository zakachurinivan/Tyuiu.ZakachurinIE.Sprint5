using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZakachurinIE.Sprint5.Task6.V28.Lib
{
    public class DataService : ISprint5Task6V28
    {
        public int LoadFromDataFile(string path)
        {
            int cnt = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] numbers = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                    foreach (string number in numbers)
                    {
                        if (number.Length == 4 && number.All(Char.IsDigit))
                        {
                            cnt++;
                        }
                    }
                }
            }
            return cnt;
        }
    }
}
