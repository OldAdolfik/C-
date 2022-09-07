// 17. Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Вы можете узнать в какой плоскости находится Ваша точка.");
Console.WriteLine("Введите координату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());
if (X==0 || Y==0) Console.WriteLine("Координаты X и Y не должны быть равными 0");
else if (X>0 && Y>0) Console.WriteLine("Точка находится в первой плоскости");
else if (X>0 && Y<0) Console.WriteLine("Точка находится во второй плоскости");
else if (X<0 && Y<0) Console.WriteLine("Точка находится в третьей плоскости");
else Console.WriteLine("Точка находится в четвёртой плоскости");