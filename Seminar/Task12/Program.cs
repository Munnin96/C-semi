// Напишите программу которая будет 
// 1. Принимать на вход 2 числа и
// 2. Выводить ,является ли первое число кратное второму 
// 3. Если 1 не кратно 2 ,выводит остаток от деления;
void Ex(int num1, int num2)
{
    if (num1 % num2 == 0)
        Console.WriteLine("Кратно");
    else
        Console.WriteLine($"Остаток {num1 % num2} ");
}
Console.WriteLine("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());

Ex(number1, number2);