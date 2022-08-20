// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 10; //можно менять количество символов в массиве.
int i = 0;

int[] arr = new int[size];
Random Ran = new Random();
int counter = 0;
for (i = 0; i < size; i++)
{
    arr[i] = Ran.Next(100, 1000);
    if (arr[i]%2 == 0) counter++;
    Console.Write($"{arr[i]} ");
    
}
Console.WriteLine("");
Console.WriteLine(counter);