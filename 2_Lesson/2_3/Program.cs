﻿// 3. Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то
// программа выводит остаток от деление.

void Kratnost(int a, int b)
{
    if (a % b == 0)
    {
        Console.WriteLine($"{a},{b} -> кратно ");
    }
    else
    Console.WriteLine($"{a},{b} -> не кратно, остаток {a%b}");
}

Kratnost(35,5);
Kratnost(167,4);