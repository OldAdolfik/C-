﻿// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int num =Convert.ToInt32(Console.ReadLine());
int SumNumbers(int num)
{
    if(num==0) return(0);
    return(num%10+SumNumbers(num/10));
}
Console.WriteLine(SumNumbers(num));