// 4. Напишите программу, которая принимает на вход число и проверяет,
// кратно ли оно одновременно 7 и 23.

void FindKrat(int number)
{
    if (number % 7 == 0 && number % 23 == 0 )
    {
        Console.WriteLine($"{number} -> Да ");
    }
    else
    Console.WriteLine($"{number} -> Нет");
}

FindKrat(14);
FindKrat(46);
FindKrat(161);