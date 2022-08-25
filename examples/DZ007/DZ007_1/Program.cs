// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5  7    -2    -0,2
// 1    -3,3  8    -9,9
// 8    7,8   -7,1 9


void Array(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11) + new Random().NextDouble();
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите размер матрицы 'm' -  ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите размер матрицы 'n' -  ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine();
Array(m, n);