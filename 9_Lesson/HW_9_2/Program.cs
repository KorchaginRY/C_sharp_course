// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int EvenNum(int N, int K)
{
    if (N > K) return 0;
    return EvenNum(N + 1, K) + N;

}

int N = int.Parse(Console.ReadLine());
int M = int.Parse(Console.ReadLine());
Console.Write($"M = {N} N = {M} -> {EvenNum(N, M)}  ");