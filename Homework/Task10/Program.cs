// Задача 10: Напишите программу, 
// 1.которая принимает на вход трёхзначное число и 
// 2.на выходе показывает вторую цифру этого числа.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

int secondDigit = SecondDigit(number1);
Console.WriteLine($"Второе число ->{secondDigit}");

int SecondDigit(int num)
{
    while (num >= 99) num /=10;
{
    num %=10;
}
    return num;
}
