Console.WriteLine("Введите номер дня недели: ");
int num1 = int.Parse(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("Это понедельник");
}
if (num1 == 2)
{
    Console.WriteLine("Это вторник");
}
if (num1 == 3)
{
    Console.WriteLine("Это среда");
}
if (num1 == 4)
{
    Console.WriteLine("Это четверг");
}
if (num1 == 5)
{
    Console.WriteLine("Это пятница");
}
if (num1 == 6)
{
    Console.WriteLine("Это суббота");
}
if (num1 == 7)
{
    Console.WriteLine("Это воскресенье");
}
else
{
    Console.WriteLine("Такого дня не существует");
}
