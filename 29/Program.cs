// Задача 29: Напишите программу, 
// которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();
Console.Write("Введите начало диапазона: ");
int begin = int.Parse(Console.ReadLine());
Console.Write("Введите конец диапазона: ");
int end = int.Parse(Console.ReadLine());
Console.Write($"[{String.Join(", ", PrintArray(begin, end))}]");
int[] PrintArray(int start, int finish)
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(start, finish);
    }
    return array;
}
