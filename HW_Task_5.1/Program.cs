// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int size = 10;                                          //Для удобства = 10, а так можно было и рандом сделать с ограничением
int del2 = 0;
int[] SuperMassive3000 = new int [size];
for (int i = 0; i < SuperMassive3000.Length; i++)
{
    SuperMassive3000[i] = new Random().Next(100,1000);
    if (SuperMassive3000[i]%2==0) del2+=1;
}
Console.WriteLine($"[{String.Join(",", SuperMassive3000)}] -> {del2}");