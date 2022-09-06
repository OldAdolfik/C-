// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int num0 = Convert.ToInt32(Console.ReadLine());
int num2 = num0%100;
num2 = num2/10;
if (num0>99 && num0<1000)
{
Console.WriteLine(num2);
}
else if (num0<-99 && num0>-1000)
{
    num2 = -num2;
    Console.WriteLine(num2);
}
else Console.WriteLine("Я просил трёхзначное число :)");