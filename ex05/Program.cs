// Написать программу вычисления произведения чисел от 1 до N
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int mult = 1;
for (int i = 1; i <= N; i++)
{
    mult = mult * i;
}
Console.WriteLine("Произведение числел от 1 до " + N + " = " + mult);