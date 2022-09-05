Console.WriteLine("Введите трёхзначное число: ");
int num1 = int.Parse(Console.ReadLine());
int num2 = num1;
while (num1>=110 && num1<1000)
{
    num1 = num1-110;

    while (num1>=10)

        num1 = num1-10;
    Console.WriteLine(num1);
}
while (num1<=-110 && num1>-1000)
{
    num1 = num1+110;

    while (num1<=-10)

        num1 = num1+10;
    Console.WriteLine(-num1);
}
if ((num2<100 && num2>-100) || (num2>999) || (num2<-999))
{
    Console.WriteLine("Это не трёхзначное число =)");
}
