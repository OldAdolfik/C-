// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int result=0;
int result1=0;
int[] massive = new int[12];
for (int i = 0; i < massive.Length; i++)
{
    massive[i] = new Random().Next(-9,10);
    if (massive[i]>0)
    {
        result=result+massive[i];
    }
    else if(massive[i]<0)
    {
        result1=result1+massive[i];
    }
}
Console.WriteLine($"В массиве: [{String.Join(",", massive)}] сумма положительных чисел равна {result}, сумма отрицательных чисел равна {result1}");