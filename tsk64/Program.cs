// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите значение N: ");
if (int.TryParse(Console.ReadLine(), out int n))
{
    if (n > 0)
    {
        Console.WriteLine("Натуральные числа в промежутке от N до 1:");
        PrintNaturalNumbers(n);
    }
    else
    {
        Console.WriteLine("N должно быть натуральным числом больше нуля.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число.");
}

static void PrintNaturalNumbers(int n)
{
    if (n >= 1)
    {
        Console.Write($"{n}");
        if (n > 1)
        {
            Console.Write(", ");
        }
        PrintNaturalNumbers(n - 1);
    }
}