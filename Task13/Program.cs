// Задача 13: Напишите программу, которая 
// 1. выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//  Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

ThirdDigit(number);

void ThirdDigit(int num)
{

    while (num > 1000) num /= 10;
    {
        if(num < 100)
        {
            Console.WriteLine("третьей цифры нет");

        }
        else
        {
            num %= 10;
            Console.WriteLine(num);
        }
    }
}