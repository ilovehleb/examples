﻿//string stroka = "abcd"; // char[] stroka = new char[] {"a","b","c","d"} (строка есть массив)
//Console.WriteLine(stroka[2]);// можно выводить отдельные символы из строки указывая их индекс.


//int num = New Random().Next(0,100) // выводим рандомное число от 0 до 99

//int[] array = new int[] {1,2,3,4,5,6,7};
/*Console.WriteLine("Введите число :   ");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
Console.WriteLine("Выходной");
}
else
{
Console.WriteLine("Рабочий день");
}*/
int x1 = Coordinate ("x", "a");
int y1 = Coordinate ("y", "a");
int z1 = Coordinate ("z", "a");
int x2 = Coordinate ("x", "b");
int y2 = Coordinate ("y", "b");
int z2 = Coordinate ("z", "b");

int Coordinate (string coorName, string pointName)
{Console.WriteLine ("Введите координату - " + coorName + " точки - " + pointName);
return Convert.ToInt16 (Console.ReadLine());}

double de (double x1, double x2, 
                 double y1, double y2, 
                 double z1, double z2)
                 
{return Math.Sqrt (Math.Pow((x2-x1), 2) + 
                   Math.Pow((y2-y1), 2) + 
                   Math.Pow((z2-z1), 2));}

double segmentLength =  Math.Round (de(x1, x2, y1, y2, z1, z2), 2 );

Console.WriteLine("Длина отрезка: " + segmentLength);
