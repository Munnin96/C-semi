// Задача 15: Напишите программу, которая 
// 1.принимает на вход цифру, обозначающую день недели, 
// 2. и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
void CheckDay(int dn)
{
    if(dn == 6 || dn == 7)
    {
        Console.WriteLine($"{dn} -> да");
    }
    else
    {
        Console.WriteLine("нет");
    }
}

Console.WriteLine("Введите цифру");
int daynumber = Convert.ToInt32(Console.ReadLine());

CheckDay(daynumber);
