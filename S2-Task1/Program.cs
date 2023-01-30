// Дано число. Проверить кратно ли оно 7 и 23

int X = new Random().Next(1,1000);
Console.WriteLine("X = " + X);

int a = X/7;
Console.WriteLine("a = " + a);

int b = X/23;
Console.WriteLine("b = " + b);

if (X-a*7 > 0)
{
    Console.WriteLine("X не кратно 7");
}
else
{
    Console.WriteLine("X кратно 7");
}

if (X-b*23 > 0)
{
    Console.WriteLine("X не кратно 23");
}
else
{
    Console.WriteLine("X кратно 23");
}

// другой вариант решения - другой синтаксис

if (X%7==0 && X%23==0) Console.WriteLine("Верно");
else Console.WriteLine("Неверно");

if (X%7==0) Console.WriteLine("Верно");
else Console.WriteLine("Неверно");