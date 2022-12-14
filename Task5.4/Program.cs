// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] UltraMassive3000 = new int [123];
int sum = 0;
for (int i = 0; i < UltraMassive3000.Length; i++)
{
    UltraMassive3000[i] = new Random().Next(1000);                   // Опять-таки для удобства делаем ограничение до тысячи
    if (UltraMassive3000[i]>=10 && UltraMassive3000[i]<=99) sum +=1;
}
Console.WriteLine($"[{String.Join(",", UltraMassive3000)}] -> {sum}");