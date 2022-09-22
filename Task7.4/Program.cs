// 51. Найти сумму элементов главной диагонали.

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
int sumDiag = 0;
for (int i = 0; i < NewArray.GetLength(0); i++)
{
    for (int j = 0; j < NewArray.GetLength(1); j++)
    {
        if(i==j) sumDiag = NewArray[i,j] + sumDiag;
    }
}
Console.WriteLine($"Сумма элементов главной диагонали: {sumDiag}");