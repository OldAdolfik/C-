// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine("Введите число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int size = new Random().Next(2,10);                   // Любой размер массива можно установить, для простоты от 2 и до 10
int[] array = new int [size];
int num2 = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);               // Любой рандом можно сделать, для простоты до 10
    if (array[i] == num1) num2 = 1;
}
if (num2 == 1) Console.WriteLine($"Массив [{String.Join(",", array)}] -> да");
else Console.WriteLine($"Массив [{String.Join(",", array)}] -> нет");