//  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

while (true)
{
int a;
int b;
double x;
Console.Write("Введите первое число :  ");
a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число :  ");
b = int.Parse(Console.ReadLine());
x = Math.Pow(a,b);
Console.WriteLine(a + " в степени " + b +" = " + x);
}