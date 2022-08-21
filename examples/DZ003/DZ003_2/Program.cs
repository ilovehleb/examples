// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты певой точки");
Console.Write("x:");
double xa = int.Parse(Console.ReadLine());
Console.Write("y:");
double ya = int.Parse(Console.ReadLine());
Console.Write("z:");
double za = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x:");
double xb = int.Parse(Console.ReadLine());
Console.Write("y:");
double yb = int.Parse(Console.ReadLine());
Console.Write("z:");
double zb = int.Parse(Console.ReadLine());
double ab = Math.Sqrt(Math.Pow(xb-xa,2)+Math.Pow(yb-ya,2)+Math.Pow(zb-za,2));
Console.WriteLine("Расстояние между точками = " + ab);