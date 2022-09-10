// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m},N={n},");

if (m < n)

    for (int i = m + 1; i < n; i++)
    {
        Console.Write($" {i}");
    }

else
    for (int i = n + 1; i < m; i++)
    {
        Console.Write($" {i}");
    }

