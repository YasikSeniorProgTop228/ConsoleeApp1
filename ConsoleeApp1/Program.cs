using System;

class Program
{
    // Метод для перевірки високосного року
    static bool IsLeapYear(int year)
    {
        // Перевірка умов високосного року
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }

    // Головний метод програми
    static void Main(string[] args)
    {
        // Запит у користувача року
        Console.Write("Введіть рік: ");
        int year;

        // Перевірка на правильність введення
        if (int.TryParse(Console.ReadLine(), out year))
        {
            // Перевірка, чи рік високосний
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} - це високосний рік.");
            }
            else
            {
                Console.WriteLine($"{year} - це не високосний рік.");
            }
        }
        else
        {
            Console.WriteLine("Будь ласка, введіть коректний рік.");
        }
    }
}
