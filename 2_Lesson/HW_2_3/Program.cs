// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

void DayOfWeek(int num)
{

    if (num == 6 || num == 7)
    {
        Console.WriteLine($"{num} -> да");
    }
    else
        Console.WriteLine($"{num} -> нет");
}

Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());
DayOfWeek(number);
