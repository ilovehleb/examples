Console.WriteLine("Введите первое число:  ");
int nA=int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int nB=int.Parse (Console.ReadLine());
Console.WriteLine("Введите третье число:  ");
int nC=int.Parse (Console.ReadLine());
if (nA >= nB && nA >= nC)
{
    Console.WriteLine("Максимальное число - " + nA);
}
else if (nB >= nA && nB >= nC)
{
    Console.WriteLine("Максимальное число - " + nB);
}
else
{
    Console.WriteLine("Максимальное число - " + nC);
}
