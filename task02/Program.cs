/*
Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

// метод получения числа на вход
double GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    double number;

    while (true)
    {
        if (double.TryParse(Console.ReadLine(), out number))
        {
            break;
        }
        else
        {
            Console.WriteLine("Гениально! Но нам нужно не это, нам нужно число.");
        }
    }
    return number;
}

// Метод нахождения точки пересечения прямых
(double, double) GetCrossLocation (double b1, double k1, double b2, double k2)
{
    double y;
    double x;

    // (k1 * x) + b1 - (k2 * x) - b2 = 0;
    // k1 * x - k2 * x = b2 - b1;
    // (k1 - k2) * x = b2 - b1;

    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;

    return (x, y);
}

Console.WriteLine("Даны две прямые, заданные уравнениями: y = k1 * x + b1, y = k2 * x + b2");
double b1 = GetNumberFromConsole("Введите число b1");
double k1 = GetNumberFromConsole("Введите число k1");
double b2 = GetNumberFromConsole("Введите число b2");
double k2 = GetNumberFromConsole("Введите число k2");
(double x, double y) = GetCrossLocation(b1, k1, b2, k2);

Console.WriteLine ($"Точка пересечения двух прямых имеет координаты [{x},{y}]");


