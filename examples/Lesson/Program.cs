//string stroka = "abcd"; // char[] stroka = new char[] {"a","b","c","d"} (строка есть массив)
//Console.WriteLine(stroka[2]);// можно выводить отдельные символы из строки указывая их индекс.


//int num = New Random().Next(0,100) // выводим рандомное число от 0 до 99

//int[] array = new int[] {1,2,3,4,5,6,7};
Console.WriteLine("Введите число :   ");
int num = int.Parse(Console.ReadLine());
if (num == 6 || num == 7)
{
Console.WriteLine("Выходной");
}
else
{
Console.WriteLine("Рабочий день");
}