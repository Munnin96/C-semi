// Напишите программу которая 
// 1. выводит случайное трехзначное число 
// 2. и удаляет вторую цифру этого числа

int number = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трёхзначное число ->{number}");

int delSec = DelSec(number);
Console.WriteLine($"Двузначное число ->{delSec}");

int DelSec(int num)
{
    int num1 = num / 100;
    int num3 = num % 10;
    int result = num1 * 10 + num3;
    return result;
}

