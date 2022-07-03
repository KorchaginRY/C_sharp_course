// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

void FindAverage(int num)
{
    if (num >= 100 && num < 1000)
    {
        int cont = num / 10;
        Console.WriteLine($"{num} -> {cont % 10}");

    }
    else
        Console.WriteLine("False");
}

Console.Write("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());
FindAverage(number);
