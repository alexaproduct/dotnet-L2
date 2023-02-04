// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.WriteLine("Введите число X");
int X = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число Y");
int Y = int.Parse(Console.ReadLine());

if (X > 0 && Y > 0) Console.WriteLine("Четверть I");

else if (X < 0 && Y > 0) Console.WriteLine("Четверть II");

else if (X < 0 && Y < 0) Console.WriteLine("Четверть III");

else Console.WriteLine("Четверть IV");
