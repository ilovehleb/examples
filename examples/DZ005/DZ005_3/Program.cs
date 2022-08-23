// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.

// [3 7 22 2 78] -> 76

int[] Arr(int length = 10, int min = 0, int max = 10)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

string PrintArray(int[] array)
{
    return (String.Join(", ", array));
}
int raznica(int[] array)
{
    int mini = 0;
    int maxi = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > array[maxi])
            maxi = i;
        if (array[i] < array[mini])
            mini = i;
    }
    return array[maxi] - array[mini];
}

int[] array = Arr(15,-100,100);
Console.Write("Mассив: ");
Console.WriteLine(PrintArray(array));
Console.Write("Разница между максимальным и минимальным числом составляет: ");
Console.WriteLine(raznica(array));