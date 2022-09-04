// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4,4];
void FillArraySpiral(int[,] array)
{
    int num = 10;
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int c = 0; c < array.GetLength(0)-1; c++)
            {
                System.Console.Write(num + " ");
                num +=1;
            }
        }
        System.Console.WriteLine();
    }
}

FillArraySpiral(array);