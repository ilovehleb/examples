// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void tochka(double k1, double b1, double k2, double b2)
{
    double x;
    double y;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
    Console.WriteLine("x=" + x + " y=" + y);
}

Console.WriteLine("Введите первую координату (b1)");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату (k1)");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату (b2)");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите первую координату (k2)");
double k2 = double.Parse(Console.ReadLine());
tochka(k1, b1, k2, b2);

