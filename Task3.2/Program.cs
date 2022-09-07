// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Показываю диапазон возможных координат точек в Вашей четверти.");
Console.WriteLine("Введите Вашу четверть: ");
int plane = Convert.ToInt32(Console.ReadLine());
if (plane==1) Console.WriteLine("X = (0; +бесконечности), Y = (0; +бесконечности)");
else if (plane==2) Console.WriteLine("X = (0; +бесконечности), Y = (0; -бесконечности)");
else if (plane==3) Console.WriteLine("X = (0; -бесконечности), Y = (0; -бесконечности)");
else if (plane==4) Console.WriteLine("X = (0; -бесконечности), Y = (0; +бесконечности)");
else Console.WriteLine("Такой четверти не существует");