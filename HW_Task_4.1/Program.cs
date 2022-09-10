// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.WriteLine("Я умею возводить число A в натуральную степень B.");
Console.WriteLine("Введите число A: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(exponent(num1,num2));
double exponent (double A, int B)
{
    int hz = B;
    while(hz==B)
    {
        A=Math.Pow(A,B);
        hz+=1;
    }
    return(A);
}

// ПОЯСНЕНИЕ. Не совсем понял зачем здесь цикл, поэтому придумал обозначение переменной hz, которая всем понятна, и сделал псевдоцикл.