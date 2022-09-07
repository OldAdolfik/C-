// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Захотелось пойти по сложному пути, а не просто через string :)

Console.WriteLine("Введите пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2=num1;
int num3=num1;
int num4=num1;
if (num1>9999 && num1<100000)
{
    num1=num1/10000;
    num2=num2%10;
    num3=num3/1000;
    num4=num4%100;
    if (num1==num2 && num3==num3) Console.WriteLine("Да, данное число является палиндромом");
    else Console.WriteLine("Нет, данное число НЕ является палиндромом");
}
else if (num1<-9999 && num1>-100000)
{
    num1=-num1/10000;
    num2=-num2%10;
    num3=-num3/1000;
    num4=-num4%100;
    if (num1==num2 && num3==num3) Console.WriteLine("Да, данное число является палиндромом");
    else Console.WriteLine("Нет, данное число НЕ является палиндромом");
}
else Console.WriteLine("Я просил пятизначное число :)");