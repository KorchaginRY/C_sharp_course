// Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNum(int N, int K)
{
    if (N % 2 != 0) N += 1;
    if (N > K) return;
    Console.Write($"{N} ");
    EvenNum(N + 1, K);
}

EvenNum(2, 12);
Console.WriteLine();
EvenNum(1, 9);