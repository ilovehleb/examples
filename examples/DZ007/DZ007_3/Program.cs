// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите размер матрицы 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите размер матрицы 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
Sum(FillArray(x, y));


int[,] FillArray(int x, int y)
{
    int[,] array = new int[x, y];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}


void Sum(int[,] array)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.WriteLine("Среднее арифметическое в колонке [" + (j+1) + "] равно -  " + sum/array.GetLength(0));
    }

}
