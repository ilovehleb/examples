﻿//Четвертая задача. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.//


Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int count = 2;

while (count < number)
{
    Console.WriteLine(count);
    count += 2;
}






