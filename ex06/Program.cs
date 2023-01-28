// Показать кубы чисел, заканчивающихся на четную цифру
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
for (int i = 2; i <= N; i = i +2)
{
    Console.WriteLine("куб числа " + i + " = " + Math.Pow(i,3));
}