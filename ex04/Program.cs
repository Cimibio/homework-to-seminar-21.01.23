﻿// Подсчитать сумму цифр в числе
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int copy = num;
int n = (int)Math.Log10(num) + 1;                       //нахождение количества цифр в числе
Console.WriteLine("Количество чисел в числе: " + n); 
int sum = 0;
while (copy != 0)                    //с помощью операции взятия остатка от деления находим крайнюю правую цифру, затем уменьшаеv исходное число в 10 раз, чтобы отбросить последнюю цифру
{
    sum += copy % 10;
    copy /= 10;
}
Console.WriteLine("Сумма цифр в числе " + num + ": " + sum);