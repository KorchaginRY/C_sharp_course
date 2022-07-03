// 1. Напишите программу, которая принимает на вход номер четверти,
//выдаёт координаты точки (X и Y).

void Quarters(int x)
{
    if (x == 1) Console.WriteLine("x > 0 & y > 0");
    else if (x == 2) Console.WriteLine("x < 0 & y > 0");
    else if (x == 3) Console.WriteLine("x < 0 & y < 0");
    else if (x == 4) Console.WriteLine("x > 0 & y < 0");
    else Console.WriteLine("Incorrect");
}

Quarters(1);
Quarters(2);
Quarters(3);
Quarters(4);
Quarters(5);