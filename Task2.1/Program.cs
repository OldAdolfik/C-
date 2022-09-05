Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine());
string[] array = new string[] {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье"};
if (day>0 && day<8)
{
    Console.WriteLine(array[day-1]);
}
else
{
    Console.WriteLine("Такого дня не существует");
}