Console.WriteLine("Введите двухзначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = num1/10;
int num3 = num1%10;
if (num1<10 || num1>99)
{
    Console.WriteLine("Не обманывай меня :)");
}
else if (num2<num3)
{
    Console.WriteLine(num3 + " - наибольшая цифра");
}
else
{
    Console.WriteLine(num2 + " - наибольшая цифра");
}