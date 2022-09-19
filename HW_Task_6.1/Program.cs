// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через пробел: ");
int [] num = Array.ConvertAll(Console.ReadLine().Split(),Convert.ToInt32);
int count = 0;
for (int i = 0; i < num.Length; i++)
{
    if (num[i]>0) count++;
}
Console.WriteLine(count);