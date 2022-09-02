// Задача 1: Задайте двумерный массив случайных чисел от 0 до 10. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 8 4 2 4
// 5 9 2 3
// 1 4 7 2

// Задача 2: Из двумерного массива случайных целых чисел от 0 до 10 удалить строку и столбец, на пересечении которых расположен наименьший элемент.

Console.WriteLine("Введите размер матрицы 'x' -  ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Введите размер матрицы 'y' -  ");
int y = int.Parse(Console.ReadLine());
Console.WriteLine();
int[,] array = new int[x, y];


void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

void ReplaseRow(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int temp = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = temp;
    }
}

void DelRowColumn(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < array[minRow, minColumn])
            {
                minRow = i;
                minColumn = j;
            }
        }
    }

}

int[,] SortArray(int[,] array)
{
    int min = array[0, 0];
    int minI = 0;
    int minJ = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (min > array[i, j])
            {
                min = array[i, j];
                minI = i;
                minJ = j;
            }
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == minI)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == minJ)
            {
                continue;
            }
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    return array;
}

FillArray(array);
System.Console.WriteLine();
ReplaseRow(array);
PrintArray(array);
System.Console.WriteLine();
FillArray(array);
System.Console.WriteLine();
SortArray(array);