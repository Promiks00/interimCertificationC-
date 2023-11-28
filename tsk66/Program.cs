// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите значение M: ");
    if (int.TryParse(Console.ReadLine(), out int m))
    {
        Console.Write("Введите значение N: ");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            if (m <= n)
            {
                int sum = CalculateSum(m, n);
                Console.WriteLine($"Сумма натуральных элементов от {m} до {n}: {sum}");
            }
            else
            {
                Console.WriteLine("Значение M должно быть меньше или равно N.");
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод для N. Пожалуйста, введите целое число.");
        }
    }
    else
    {
        Console.WriteLine("Некорректный ввод для M. Пожалуйста, введите целое число.");
    }

static int CalculateSum(int m, int n)
{
    int sum = 0;

    for (int i = m; i <= n; i++)
    {
        sum += i;
    }

    return sum;
}