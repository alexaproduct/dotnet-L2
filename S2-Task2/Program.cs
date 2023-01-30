// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

int X = new Random().Next(0,8);
Console.WriteLine("X = " + X);

if (X < 6)
{
    Console.WriteLine("будний день");
}
else
{
    Console.WriteLine("выходной день");
}