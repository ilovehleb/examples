// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите любое число : ");
string stroka = Console.ReadLine();
if (stroka.Length>=3){Console.WriteLine(stroka[2]);}
else {Console.WriteLine("Третьей цифры нет.");}