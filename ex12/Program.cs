// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] array = new int[10];
for (int i = 0; i <= 9; i++)
{
    array[i] = new Random().Next(0,10);
    Console.Write(array[i] + ", ");
}
int[] multy_array = new int[5];
Console.WriteLine();
Console.WriteLine("Произведение пар чисел в одномерном массиве:");
for (int i = 0; i <= 4; i++)
{
    multy_array[i] = array[i] * array[array.Length - 1 - i];
    Console.WriteLine(multy_array[i]);
}
