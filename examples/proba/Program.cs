            Console.WriteLine("Чисел в массиве:  ");
            int x = int.Parse(Console.ReadLine());
            int[] array = new int[x];
            int sum = 0;
            Random rnd = new Random();
            Console.Write("Mасив: ");
            for (int i = 0; i < x; i++)
            {
                array[i] = rnd.Next(-50, 51);//заполняем массив случайными числами
                Console.Write(array[i] + " ");
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }
            Console.WriteLine("Сумма = " + sum);