// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.WriteLine("Введите первое число");
int numbera = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int numberc = Convert.ToInt32(Console.ReadLine());

int max = numbera;

if (numberb > max) max = numberb;
if (numberc > max) max = numberc;

Console.Write("Максимальное число  = ");
Console.WriteLine(max);