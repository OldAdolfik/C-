// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Нахожу расстояние между двумя точками.");
Console.WriteLine("Введите координату X и Y первой точки: ");
Console.Write("X1: ");
double X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y1: ");
double Y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X и Y второй точки: ");
Console.Write("X2: ");
double X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Y2: ");
double Y2 = Convert.ToDouble(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(X2-X1, 2) + Math.Pow(Y2-Y1,2));
Console.WriteLine($"Расстояние между точками = {Math.Round(result,2)}");
