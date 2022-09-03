//  Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

int m = 1;
int n = 10;
int NaturalInteger(int m, int n)
{
    if (m > n && n > 0)
    {
        return NaturalInteger(n,m);
    }
    else if (m > 0 && m < n)
    {
        System.Console.Write(m + " ");
        return NaturalInteger(m + 1, n);
    }
    else
    {
        return m;
    }
}
NaturalInteger(m, n);