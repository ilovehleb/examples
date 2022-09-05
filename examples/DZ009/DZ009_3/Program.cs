// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 29

int m = 2;
int n = 3;
int Akkerman(int m, int n)
{
  if (m == 0)
    return m + 1;
  else
    if ((m != 0) && (m == 0))
      return Akkerman(m - 1, 1);
    else
      return Akkerman(m - 1, Akkerman(m, m - 1));
}
Console.WriteLine(Akkerman(m,n));