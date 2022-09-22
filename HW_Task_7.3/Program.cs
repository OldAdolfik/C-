// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2Array(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 11);
        }
    }
    return (array);
}
void PrintArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}
int[,] NewArray = CreateRandom2Array(a, b);
Console.WriteLine("Массив: ");
PrintArray(NewArray);
double sum = 0;
int c = a;
Console.Write("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < NewArray.GetLength(1); j++)
{
    a=c-1;
    sum = 0;
    while(a>=0)
    {
        sum+=NewArray[a,j];
        a--;
    }
    sum=sum/c;
    Console.Write(sum + "; ");
}