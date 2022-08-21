// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите лююбое целое число:  ");
string xi = Console.ReadLine();
int count = xi.Length;
int x = int.Parse (xi);
int i = 0;
int sum = 0;
Console.WriteLine("Количество знаков в числе - " + count + ".");

while (i < count)
            {
                sum += x % 10;
                x = x /10 ;
                i++;
            }
Console.Write("Сумма всех чисел в числе '" + xi + "' равна - " + sum + ".");