// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] array = new int[10];
int odd_sum = 0;
for (int i = 1; i <= 9; i = i + 2)
{
    array[i] = new Random().Next(0,10);
    odd_sum = odd_sum + array[i];
}
Console.WriteLine();
Console.WriteLine("Сумма чисел на нечетных позициях в массиве = " + odd_sum);
