// Задача 26: Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.WriteLine("Введите целое натуральное число");
int num = Convert.ToInt32(Console.ReadLine());

int counter = NumCount(num);
Console.WriteLine($"Количество числе в числе -> {counter}");

int NumCount(int number)
{
    if(number < 0) number = number * -1;
    int count = 0;
    for (int i = 0; number > 0; i++)
    {
        number = number / 10 ;
        count ++;
    }
    return count;
}