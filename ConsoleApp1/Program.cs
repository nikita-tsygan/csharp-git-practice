using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        // Привет! Арбуз, кот, яблоко и собака гуляют в Apple garden.
        Console.Write("Введите строку: ");
        string text = Console.ReadLine();
        Console.WriteLine("Исходный текст:");
        Console.WriteLine(text);

        // Регулярное выражение для поиска русских слов, начинающихся на согласную
        string pattern = @"\b[бвгджзйклмнпрстфхцчшщБВГДЖЗЙКЛМНПРСТФХЦЧШЩ][а-яА-ЯёЁ]*\b";

        // Удаление найденных слов (замена на пустую строку)
        string result = Regex.Replace(text, pattern, "");

        // Удаление лишних пробелов, оставшихся после удаления слов
        result = Regex.Replace(result, @"\s+", " ").Trim();

        Console.WriteLine("\nРезультат после удаления:");
        Console.WriteLine(result);
    }
}