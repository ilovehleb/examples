Console.WriteLine("Введите цифру дня недели");

int number=int.Parse (Console.ReadLine());

if (number == 1)
{
    Console.Write("Это понедельник.");
}
else if (number == 2)
{
    Console.Write("Это вторник.");
}
else if (number == 3)
{
    Console.Write("Это среда.");
}
else if (number == 4)
{
    Console.Write("Это четверг.");
}
else if (number == 5)
{
    Console.Write("Это пятница.");
}
else if (number == 6)
{
    Console.Write("Это суббота.");
}
else if (number == 7)
{
    Console.Write("Это воскресенье.");
}
else
{
  Console.Write("Такого дня недели не существует))");
}
