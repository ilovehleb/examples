// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

int[] arr(int length, int min = 0, int max = 10)
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    return result;
}

int sum(int[] array)
{
    int result = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        result += array[i];
    }
    return result;
}

Console.Write("Введите длину массива:");
int x = int.Parse(Console.ReadLine());
int[] array = arr(x);
Console.Write("Mассив: ");
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.Write("Сумма элементов: ");
Console.WriteLine(sum(array));
