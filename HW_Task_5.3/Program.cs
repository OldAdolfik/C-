// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int size = new Random().Next(2, 11);
double max = -1000000000000;
double min = 1000000000000;
double[] array = new double [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-100, 101);
    if (array[i]>max) max = array[i];
    if (array[i]<min) min = array[i];
}
Console.WriteLine($"[{String.Join(" ", array)}] -> {max-min}");