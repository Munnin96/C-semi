// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите целое число: ");
int Number = Convert.ToInt32(Console.ReadLine());

int sumnumber = SumNumber(Number);
Console.WriteLine($"Сумма чисел в числе {Number} -> {sumnumber}");

int SumNumber(int num)
{
    int result = 0;
    int counter = num;
    int advance = 0;
    for (int i = 0; i < counter; i++)
    {
        advance = num - num % 10;
        result = result + (num - advance);
        num = num / 10;
    }
    return result;
}