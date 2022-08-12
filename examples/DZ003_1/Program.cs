// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("введите число");
string num = Console.ReadLine();
string rev = string.Concat(num.Reverse());
if (num == rev){Console.WriteLine("палиндром");}
else {Console.WriteLine("не палиндром");}