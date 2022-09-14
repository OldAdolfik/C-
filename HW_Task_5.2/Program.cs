// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int size = new Random().Next(2, 11);                                //Ограничения для простой проверки
int sum = 0;                                         
int[] SuperMegaMassive4000 = new int [size];
for (int i = 0; i < SuperMegaMassive4000.Length; i++)
{
    SuperMegaMassive4000[i] = new Random().Next(-100, 101);         //Ограничения для простой проверки
    if (i>0)
    {
        if (i%2==1) sum = sum+SuperMegaMassive4000[i];
    }
}
Console.WriteLine($"[{String.Join(",", SuperMegaMassive4000)}] -> {sum}");
