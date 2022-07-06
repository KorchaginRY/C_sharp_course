
void SumA(int n)
{
    int sum = 0;
    for (int i = 1; i <= n; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine($"{n} -> {sum}");
}
SumA(7);
SumA(4);
SumA(8);
