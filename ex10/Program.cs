// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]
int[] array = new int[123];
int count = 0;
for (int i = 0; i <= 122; i++)
{
    array[i] = new Random().Next(0,200);
//    Console.Write(array[i] + ", ");
    if (array[i] >= 10 && array[i] <= 99) count++;
}
Console.WriteLine("Количество элементов внутри отреза [10,99] = " + count);
