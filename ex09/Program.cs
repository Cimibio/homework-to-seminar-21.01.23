// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] array = new int[10];
int even_count = 0;
int odd_count = 0;
for (int i = 0; i <= 9; i++)
{
    array[i] = new Random().Next(100,1000);
    Console.Write(array[i] + ", ");
    if (array[i] % 2 == 0) even_count++;
    else odd_count++;
}
Console.WriteLine();
Console.WriteLine("Количество четных чисел в массиве = " + even_count);
Console.WriteLine("Количество нечетных чисел в массиве = " + odd_count);