// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int size = 8; //можно менять количество символов в массиве.
int i = 0;

int[] arr = new int[size];
Random Ran = new Random();

for (i = 0; i < size; i++)
{
    arr[i] = Ran.Next(0, 10);
    Console.Write($"{arr[i]} ");
}
