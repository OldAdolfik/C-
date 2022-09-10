// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumNumbers(num1));
int SumNumbers (int end)
{
    int sum=0;
    if (end>0)
{
    for (int i = 1; i <= end; i++)
    {
    sum = sum+i;
    }
    return(sum);
}
else if (end<0)
{
    for (int i = -1; i >= end; i--)
    {
        sum=sum+i;
    }
    return(sum);
}
else 
{
    int zero = 0;
    return(zero);
}
}