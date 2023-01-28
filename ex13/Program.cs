// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом
double[] array = new double[10];
for (int i = 0; i <= 9; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + ", ");
}