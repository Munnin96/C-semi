// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] arr = FillArray(8);
PrintArray(arr);
Console.WriteLine();
PrintArray2(arr);

int[] FillArray(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(0, 100);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length-3; i++)
    {
        Console.Write($"{array [i] } ");
    }
}
void PrintArray2(int[] array)
{
    for (int i = 5; i < array.Length; i++)
    {
        Console.Write($"{array [i] } ");
    }
}