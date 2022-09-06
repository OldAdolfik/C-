// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Думал как-нибудь так сделать

// Console.WriteLine("Введите число: ");
// int num0 = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[] {num0};
// Console.WriteLine(array[2]);

Console.WriteLine("Введите число: ");
int num0 = Convert.ToInt32(Console.ReadLine());
int num1 = num0;
if (num0>99)
{
    while (num1>999) num1=num1/10;
num0=num1%10;
Console.WriteLine(num0);
}
else if (num0<100 && num0>-100) Console.WriteLine("Третьей цифры нет");
else
{
    while (num1<-999) num1=num1/10;
num0=-num1%10;
Console.WriteLine(num0);
}