// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(MultOfNumbers(num1));
int MultOfNumbers (int end)
{
    int mult=1;
    if (end>0)
    {
        for (int i = 1; i <= end; i++)
        {
            mult=mult*i;
        }
        return(mult);
    }
    else if (end<0)
    {
        for (int i = -1; i >= end; i--)
        {
            mult=mult*i;
        }
        return(mult);
    }
    else 
    {
        int zero=0;
        return(zero);
    }
}