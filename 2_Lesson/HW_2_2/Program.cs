// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FindLast(int num1)
{
    int num = num1;
    if (num > 99)
    {
        while (num >= 1000)
        {
            num = num / 10;
        }
        int cont = num % 10;
        Console.WriteLine($"{num1} -> {cont % 10}");

    }
    else
        Console.WriteLine($"{num1} -> третьей цифры нет");
}

Console.Write("Введите значение: ");
int number = int.Parse(Console.ReadLine());
FindLast(number);
