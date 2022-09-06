int num0 = new Random().Next(100,1000);  //[100...999]
Console.WriteLine("Случайное число: " + num0);
int num1 = num0/100;
int num3 = num0%10;
Console.WriteLine("Крайняя левая и крайняя правая цифры: " + num1 + "" + num3);