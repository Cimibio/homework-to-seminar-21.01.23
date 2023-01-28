// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];
for (int i = 0; i <= 9; i++)
{
    array[i] = new Random().NextDouble() * 10;
    Console.WriteLine(array[i] + ", ");
}
Console.WriteLine();
Console.WriteLine("Минимальное число массива: " + array.Min());
Console.WriteLine("Максимальное число массива: " + array.Max());
Console.WriteLine("Разница максимального и минимального числа: " + (array.Max() - array.Min()));