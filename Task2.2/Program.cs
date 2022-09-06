// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. 456 -> 46 782 -> 72 918 -> 98

Console.WriteLine("Введите трёхзначное число: ");
int num0 = Convert.ToInt32(Console.ReadLine());
int num1 = num0/100;
int num3 = num0%10;
if (num0<100 || num0>999)
{
    Console.WriteLine("Мне кажется, что ты не умеешь читать :)");
}
else Console.WriteLine(num1 + "" + num3);