// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
if (num1>0)
{
    while (num2<=num1)
    {
    Console.WriteLine(num2*num2*num2);
    num2++;
    }
}
else if (num1<0)
{
    num2=-num2;
    while (num2>=num1)
    {
        Console.WriteLine(num2*num2*num2);
        num2--;
    }
}
else Console.WriteLine("1, 0");