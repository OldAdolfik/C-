﻿// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (num1>0)
{
    for (int i = 1; i <= num1; i++)
    {
    sum = sum+i;
    }
    Console.WriteLine($"Сумма чисел от 1 до Вашего числа = {sum}");
}
else if (num1<0)
{
    for (int i = -1; i >= num1; i--)
    {
        sum=sum+i;
    }
    Console.WriteLine($"Сумма чисел от -1 до Вашего числа = {sum}");
}
else Console.WriteLine($"Сумма чисел от 1 до Вашего числа = 0");