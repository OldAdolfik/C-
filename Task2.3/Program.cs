// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если число 2 не кратно числу 1, то программа выводит остаток от деления. 34, 5 -> не кратно, остаток 4 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num1%num2==0)
{
    double num3 = num1/num2;
    Console.WriteLine("Кратно, результат при делении = " + num3);
}
else
{
    double num4 = num1%num2;
    double num3 = num1/num2;
    Console.WriteLine("Не кратно, остаток = " + num4 + ", результат при делении = " + num3);
}
