// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите начальное число M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите начальное число N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M={m},N={n},");
int sum = 0;
if (m < n)

    for (int i = m + 1; i < n; i++)
    {
        sum += i;
    }

else
    for (int i = n + 1; i < m; i++)
    {
        sum += i;
    }

Console.Write($"Сумма натуральных элементов в промежутке от M до N = {sum}");