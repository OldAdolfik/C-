// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int size = new Random().Next(10);                          //Можно ставить любой размер массива
int[] array = new int [size];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
}
Console.Write($"[{String.Join(",", array)}] ->");
for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i]*(-1);
}
Console.Write($" [{String.Join(",", array)}]");