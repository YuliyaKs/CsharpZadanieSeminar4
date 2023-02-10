// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма цифр = {NumbersSum(number)}");
int NumbersSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num /=10;
    }
    return result;
}