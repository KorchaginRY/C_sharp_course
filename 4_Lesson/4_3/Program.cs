// 2. Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N.


void MultiplicationN(int n)
{
    int sum = 1;
    for (int i = 1; i <= n; i++)
    {
        sum = sum * i;
    }
    Console.WriteLine($"{n} -> {sum}");
}
MultiplicationN(3);
MultiplicationN(4);
MultiplicationN(5);
