// Возведите число А в натуральную степень B используя цикл
Console.Write("Введите число которое будем возводить в степень: ");
int A = int.Parse(Console.ReadLine());
int num = A;
Console.Write("Введите степень: ");
int B = int.Parse(Console.ReadLine());
for ( int i = 1; i < B ; i++)
{
    A = A * num;
}
Console.WriteLine(A);