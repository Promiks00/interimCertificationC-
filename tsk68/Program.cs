// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите значение m: ");
if (uint.TryParse(Console.ReadLine(), out uint m))
{
    Console.Write("Введите значение n: ");
    if (uint.TryParse(Console.ReadLine(), out uint n))
    {
        uint result = AckermannFunction(m, n);
        Console.WriteLine($"A({m}, {n}) = {result}");
    }
    else
    {
        Console.WriteLine("Некорректный ввод для n. Пожалуйста, введите неотрицательное целое число.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод для m. Пожалуйста, введите неотрицательное целое число.");
}

static uint AckermannFunction(uint m, uint n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return AckermannFunction(m - 1, 1);
    }
    else
    {
        return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    }
}