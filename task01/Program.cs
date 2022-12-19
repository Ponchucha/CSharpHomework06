/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3 */

// метод получения массива чисел на вход
int[] GetArrayFromConsole(string message)
{
    Console.WriteLine("Введите числа через запятую или пробел");

    string inputString = Console.ReadLine() ?? "";
    char[] charSeparator = { ' ', ',' }; // здесь указаны разделители, которые будут использоваться в методе Split
    string[] arrayStr = inputString.Split(charSeparator, StringSplitOptions.RemoveEmptyEntries); // Split - преобразует текст в массив строк. 
    // StringSplitOptions.RemoveEmptyEntries - необязательный параметр, убирающий пустые элементы

    int[] array = new int[arrayStr.Length]; // создаём массив натуральных чисел, куда будем складывать значения
    for (int i = 0; i < arrayStr.Length; i++)
    {
        int number;
        while (true)
        {
            if (int.TryParse(arrayStr[i], out number))
            {
                array[i] = number;
                break;
            }
            else
            {
                Console.WriteLine($"{arrayStr[i]} - не число. Даже на него не похоже. Введите нормальное число взамен.");
                arrayStr[i] = Console.ReadLine() ?? "";
            }
        }
    }
    return array;
}

// метод печати массива
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length - 1]}]");
    Console.WriteLine();
}

// метод подсчёта количества положительных элементов

int CountPositiveNumbers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}


int[] array = GetArrayFromConsole("Введите элементы массива");
Console.Write($"Задан массив из {array.Length} чисел: ");
PrintArray(array);
Console.WriteLine($"Количество положительных элементов массива равно {CountPositiveNumbers(array)}");

