// 3. Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

void Fibo(int num)
{
    int num1 = 0;
    int num2 = 1;

    for (int i = 0; i < num; i++)
    {
        Console.Write($"{num1} ");
        (num1, num2) = (num2, num1 + num2);
    }
}

Fibo(6);