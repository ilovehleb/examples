
Console.Clear();
double Fibonacci(int n)
{
    if (n == 0 || n == 1) return 1;
    else return (Fibonacci(n - 1) + Fibonacci(n - 2));
}
for (int i = 0; i < 42; i++)
{
    Console.WriteLine($"F({i}) = {Fibonacci(i)}");
}
