// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

Console.Clear();
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine($"{A} ^ {B} = {NumPower(A, B)}");
int NumPower(int number, int power)
{
    int result = 1;
    for (int i = 1; i <= power; i++)
    {
        result = result * number;
    }
    return result;
}