using System;

namespace Lection_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red; //Изменить цвет заднего фона
            Console.ForegroundColor = ConsoleColor.Blue; //Изменить цвет шрифта
            Console.Clear(); //Очистить консоль

            Console.WriteLine("Введите фамилию: "); //Вывести то, что в скобках на экран
            var family = Console.ReadLine(); //Считать строку и положить ее в переменную (слева от знака = )
            Console.WriteLine("Введите имя: "); //Вывести то, что в скобках на экран
            var name = Console.ReadLine(); //Считать строку и положить ее в переменную (слева от знака = )
            Console.WriteLine("Введите отчество: "); //Вывести то, что в скобках на экран
            var patronymic = Console.ReadLine(); //Считать строку и положить ее в переменную (слева от знака = )

            Console.BackgroundColor = ConsoleColor.Yellow; //Изменить цвет заднего фона
            Console.ForegroundColor = ConsoleColor.Green; //Изменить цвет шрифта
            Console.Clear(); //Очистить консоль

            Console.WriteLine(family); //Вывести то, что в скобках на экран
            Console.WriteLine(name); //Вывести то, что в скобках на экран
            Console.WriteLine(patronymic); //Вывести то, что в скобках на экран

        }
    }
}
