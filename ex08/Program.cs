// Определить, присутствует ли в заданном массиве, некоторое число
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[8];
int flag = 0;
for (int i = 0; i <= 7; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + ", ");
    if (N == array[i]) flag = 1;
}
if (flag == 1) Console.WriteLine("В массиве есть число " + N);
else Console.WriteLine("В массиве нет чиса " + N);
