﻿// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите длину первой стороны треугольника: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину второй стороны треугольника: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите длину третьей стороны треугольника: ");
int num3 = Convert.ToInt32(Console.ReadLine());
if (num1<num2+num3 && num2<num1+num3 && num3<num1+num2) Console.WriteLine($"Треугольник со сторонами {num1}, {num2}, {num3} СУЩЕСТВУЕТ.");
else Console.WriteLine("Треугольник с заданными сторонами НЕ МОЖЕТ СУЩЕСТВОВАТЬ.");