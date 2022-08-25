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

            void FillArray(int[,] array)
{
  double middle=0;
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i,j] = new Random().Next(10,51);
      Console.Write(array[i,j]+ " ");
      middle = middle + array[i, j];

    }
    Console.WriteLine(" ");
    Console.WriteLine("Среднее арифметическое строчки " + (i+1) + " равно " +(middle /  array.GetLength(0)));
  }
 
}
int[,] array = new int[4, 4];

FillArray(array);