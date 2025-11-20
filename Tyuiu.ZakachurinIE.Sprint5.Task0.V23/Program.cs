using Tyuiu.ZakachurinIE.Sprint5.Task0.V23.Lib;

namespace Tyuiu.ZakachurinIE.Sprint5.Task0
{
    class Program

    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт # 5 | Выполнил: Закачурин И. Е. | ИБКСб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Варинат #23                                                             *");
            Console.WriteLine("* Выполнил: Закачурин Иван Евгеньевич | ИБКСб-25-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* результат сохранить в текстовый файл                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int x = 3;
            Console.WriteLine(x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.SaveToFileTextData(x));
            Console.WriteLine("Готов");
            Console.ReadKey();
        }
    }
}