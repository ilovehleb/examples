// Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый 
//- на последнем и т.д.). 
// Элементы массива задаются случано и лежат в промежутке от -10 до 10

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]
int[] fillarray(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10, 11);
        Console.Write(array[i] + " ");
    }
    return array;
}
void arrayrev(int[] array)
{
    int size = array.Length;

    for (int i = 0; i < size / 2; i++)
    {
        int temp = array[i];
        array[i] = array[size - i -1];
        array[size -i -1] = temp;
    }
}
int[] arr = fillarray(10);

arrayrev(arr);
Console.WriteLine();

foreach(int item in arr)
{
    Console.Write(item + " ");
}








// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33
