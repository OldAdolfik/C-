// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int b = Convert.ToInt32(Console.ReadLine());
double [,] CreateRandom2Array(int rows, int columns)
{
    double [,] newArray = new double[rows, columns];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i,j] = (new Random().NextDouble()*10);
        }
    }
    return(newArray);
}
void Print2Array(double[,] inputArray)
{
for (int i = 0; i < inputArray.GetLength(0); i++)
{
    for (int j = 0; j < inputArray.GetLength(1); j++)
    {
        Console.Write(inputArray[i,j] + " ");
    }
    Console.WriteLine();
}
}
double [,] ArrayForTask = CreateRandom2Array(a,b);
Print2Array(ArrayForTask);