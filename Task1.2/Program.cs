Console.WriteLine("Введите номер дня недели: ");
int num1 = int.Parse(Console.ReadLine());
if (num1 == 1) Console.WriteLine("Это понедельник");
else if (num1 == 2) Console.WriteLine("Это вторник");
else if (num1 == 3) Console.WriteLine("Это среда");
else if (num1 == 4) Console.WriteLine("Это четверг");
else if (num1 == 5) Console.WriteLine("Это пятница");
else if (num1 == 6) Console.WriteLine("Это суббота");
else if (num1 == 7) Console.WriteLine("Это воскресенье");
else Console.WriteLine("Такого дня не существует");

