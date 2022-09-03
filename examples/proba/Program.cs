// Console.WriteLine("Чисел в массиве:  ");
// int x = int.Parse(Console.ReadLine());
// int[] array = new int[x];
// int sum = 0;
// Random rnd = new Random();
// Console.Write("Mасив: ");
// for (int i = 0; i < x; i++)
// {
//     array[i] = rnd.Next(-50, 51);//заполняем массив случайными числами
//     Console.Write(array[i] + " ");
//     if (array[i] > 0)
//     {
//         sum += array[i];
//     }
// }
// Console.WriteLine("Сумма = " + sum);

//             void FillArray(int[,] array)
// {
//   double middle=0;
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i,j] = new Random().Next(10,51);
//       Console.Write(array[i,j]+ " ");
//       middle = middle + array[i, j];

//     }
//     Console.WriteLine(" ");
//     Console.WriteLine("Среднее арифметическое строчки " + (i+1) + " равно " +(middle /  array.GetLength(0)));
//   }

// }
// int[,] array = new int[4, 4];

// FillArray(array);

Console.WriteLine("Введите размер массива -  "); //Программа по выводу четных чисел из массива.
int x = int.Parse(Console.ReadLine());
Console.WriteLine();
int[] array = new int[x];


int[] Array(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        array[i] = new Random().Next(10, 100);
        Console.Write(array[i] + " ");
    }
    return array;
}


void Number(int[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i] % 2 == 0)
        {
            Console.Write(array[i] + " ");
        }
    }
}
Array(array);
System.Console.WriteLine();
Number(array);