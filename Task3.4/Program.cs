// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
if (num1>0)
{
    while (num2<=num1)
{
    Console.Write(num2*num2 + " ");
    num2++;
}}
else if (num1<0)
{
    num2=-num2;
    while (num2>=num1)
    {
        Console.Write(num2*num2 + " ");
        num2--;
    }
}
else Console.WriteLine("1, 0");
