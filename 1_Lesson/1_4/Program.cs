Console.Write("Введите значение: ");
int num = int.Parse(Console.ReadLine());
int i = -num;

while (i <= num)
{
    Console.Write(i + " ");
    i++;
}

Console.ReadLine();
