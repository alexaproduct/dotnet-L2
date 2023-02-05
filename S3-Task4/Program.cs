// Задача 4: Программа проверяет пятизначное число на палиндромом.


Console.Write("Введи пятизначное число: ");
int fiveDigitNumber = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(fiveDigitNumber);

int i1 = stringNumber[0];
int i2 = stringNumber[1];
int i3 = stringNumber[2];
int i4 = stringNumber[3];
int i5 = stringNumber[4];

if (i1 == i5 && i2 == i4) Console.WriteLine ("палиндром");
else Console.WriteLine("не палиндром");