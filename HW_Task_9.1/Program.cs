// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое число:");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
int SumNumbers(int start, int end)
{
    if (start == end) return (start);
    if (start <= end)
    {
        int sum = 0;
        sum = start + SumNumbers(start + 1, end);
        return (sum);
    }
    else return (0);
}
Console.WriteLine(SumNumbers(M, N));
