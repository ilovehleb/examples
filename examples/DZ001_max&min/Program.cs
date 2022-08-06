Console.WriteLine("Введите первое число:  ");
int numA=int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число:  ");
int numB=int.Parse (Console.ReadLine());
if (numA > numB)
{
    Console.WriteLine("Наибольшее число - " + numA + "   Наименьшее число - " + numB);

}
else if (numA < numB)
{
    Console.WriteLine("Наибольшее число - " + numB + "   Наименьшее число - " + numA);
}
else
{
    Console.WriteLine("Они равны");
}
