Console.WriteLine("Введите число N - ");
int N = int.Parse (Console.ReadLine());
int count = 2;
Console.WriteLine("Четные числа от 1 до N :");
while (count < N)
{
    if (count%2 == 0)
    {
        Console.WriteLine(count);
        count += 2;

    }
}
