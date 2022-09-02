// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите размер матрицы 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите размер матрицы 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array0 = new int[x, y];
int[,] array1 = new int[x, y];

int[,] FillArray(int[,] array0)
{
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            array0[i, j] = new Random().Next(0, 10);
            Console.Write(array0[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array0;
}

void Produkt(int[,] array0, int[,] array1)
{
    int[,] matrix = new int[array0.GetLength(0), array0.GetLength(1)];
    for (int i = 0; i < array0.GetLength(0); i++)
    {
        for (int j = 0; j < array0.GetLength(1); j++)
        {
            matrix[i, j] = array0[i,j] * array1[i,j];
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Первый массив :");
FillArray(array0);
System.Console.WriteLine();
System.Console.WriteLine("Второй массив :");
FillArray(array1);
System.Console.WriteLine();
System.Console.WriteLine("Произведение массивов :");
Produkt(array0, array1);