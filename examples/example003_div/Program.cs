Console.WriteLine("Введите первое число");

int numberA=int.Parse (Console.ReadLine());

Console.WriteLine("Введите второе число");

int numberB=int.Parse (Console.ReadLine());

if (numberA == numberB*numberB)
{
    Console.WriteLine("Первое число является квадратом второго.");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго.");   
}