// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте,
// а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(-100, 101);
}
Console.Write($"[{String.Join(",", array)}] -> ");
for (int i = 0; i < size/2; i++)
{
    int num1=array[i];
    array[i] = array[size-1-i];
    array[size-1-i] = num1;
}
Console.WriteLine($"[{String.Join(",", array)}]");