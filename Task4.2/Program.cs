// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// Console.WriteLine(number.Length);

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(CountNumbers(num1));
int CountNumbers (int num)
{
    int count = 0;
    if (num>0)
    {
        while (num>0)
        {
            num=num/10;
            count++;
        }
        return(count);
    }
    else if (num<0)
    {
        while (num<0)
        {
            num=num/10;
            count++;
        }
        return(count);
    }
    else return(count+1);
}