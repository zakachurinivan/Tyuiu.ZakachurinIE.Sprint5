using Tyuiu.ZakachurinIE.Sprint5.Task6.V28.Lib;
using System.IO;
namespace Tyuiu.ZakachurinIE.Sprint5.Task6.V28
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            string path = @"C:\Users\Пользователь\DataSprint5\InPutDataFileTask6V28.txt";
            Console.Title = "Спринт # 5 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Варинат #28                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* результат сохранить в текстовый файл                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(path);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.LoadFromDataFile(path));
            Console.WriteLine("Completed");
            Console.ReadKey();
        }
    }
}