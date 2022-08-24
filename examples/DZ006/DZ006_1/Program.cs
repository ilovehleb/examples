// Задача 41: Пользователь вводит с клавиатуры N чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количесво чисел :  ");
int c = int.Parse(Console.ReadLine());
Console.Write("Массив чисел:  ");

int[] fillarray(int capacity)
{
    int[] array = new int[capacity];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1001);
        Console.Write(array[i] + " ");
    }
    return array;
}

int[] array = fillarray(c);

// Console.WriteLine("Введите массив чисел через запятую.");
// int[] array = int.Parse(Console.ReadLine());
// Console.WriteLine(array);

int counter(int[] array)
{
    int x = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            i++;
            x++;
        }
        else
        {
            i++;
        }
    }
    return x;
}
int count = counter(array);
Console.WriteLine();
Console.WriteLine("Количество положительных чисел -  " + count);