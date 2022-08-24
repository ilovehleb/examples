//string stroka = "abcd"; // char[] stroka = new char[] {"a","b","c","d"} (строка есть массив)
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
// int x1 = Coordinate ("x", "a");
// int y1 = Coordinate ("y", "a");
// int z1 = Coordinate ("z", "a");
// int x2 = Coordinate ("x", "b");
// int y2 = Coordinate ("y", "b");
// int z2 = Coordinate ("z", "b");

// int Coordinate (string coorName, string pointName)
// {Console.WriteLine ("Введите координату - " + coorName + " точки - " + pointName);
// return Convert.ToInt16 (Console.ReadLine());}

// double de (double x1, double x2, 
//                  double y1, double y2, 
//                  double z1, double z2)

// {return Math.Sqrt (Math.Pow((x2-x1), 2) + 
//                    Math.Pow((y2-y1), 2) + 
//                    Math.Pow((z2-z1), 2));}

// double segmentLength =  Math.Round (de(x1, x2, y1, y2, z1, z2), 2 );

// Console.WriteLine("Длина отрезка: " + segmentLength);


int a1 = 12;
int a2 = 31;
int a3 = -8;
int b1 = 45;
int b2 = 7;
int b3 = 0;
int c1 = -2;
int c2 = 14;
int c3 = 99;

int Max(int arg1, int arg2, int arg3)
{
    int result = a1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int max1 = Max(a1, a2, a3);
int max2 = Max(b1, b2, b3);
int max3 = Max(c1, c2, c3);
int total = Max(max1,max2,max3);


Console.WriteLine(total);
