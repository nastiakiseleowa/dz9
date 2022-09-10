// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите неотрицательное число m:");
uint m = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n:");
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine($"m={m},n={n},");

static uint A(uint m, uint n)
{
    //Console.WriteLine($"{m} {n}");
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return A(m - 1, 1);
    else
      return A(m - 1, A(m, n - 1));
}

uint res;
res = A(m,n);
Console.WriteLine(res);