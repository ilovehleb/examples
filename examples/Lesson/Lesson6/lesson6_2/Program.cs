// Задача 2. Вычислить среднее арифметическое положительных элементов в одномерном массиве. 
// Элементы массива задаются случано и лежат в промежутке от -10 до 10

// [1, -5, 8, 4, -9] -> 4.33

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

int[] array = fillarray(10);
Console.WriteLine();


double sum = 0;
int i = 0;
int x = 0;
while (i < array.Length)
{
    if (array[i]>0)
    {
        sum = sum + array[i];
        i++;
        x++;
    }
    else{i++;}
}
Console.WriteLine(sum/x);