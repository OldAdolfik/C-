// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

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
Console.WriteLine("Введите позицию элемента (строка, столбец): ");
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

if(c>a || d>b) Console.WriteLine($"{c}, {d} -> такого числа в массиве нет");
else 
{
    Console.Write($"{c}, {d} -> ");
    a=c-1;
    b=d-1;
    Console.WriteLine(NewArray[a,b]);
}
// for (int i = 0; i < NewArray.GetLength(0); i++)
// {
//     for (int j = 0; j < NewArray.GetLength(1); j++)
//     {
        
//     }
// }