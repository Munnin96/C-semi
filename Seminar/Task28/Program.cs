﻿// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.WriteLine("Введите целое число : ");
int number = Convert.ToInt32(Console.ReadLine());

int factorial = Factorial(number);
Console.WriteLine($"Факториал числа {number} -> {factorial}");

int Factorial(int num)
{
    int Fact = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            Fact *= i;
        }
    }
    return Fact;
}