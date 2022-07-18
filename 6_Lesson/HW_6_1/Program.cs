// Пользователь вводит с клавиатуры М чисел. 
// Посчитать сколько чисел больше 0 ввел пользователь.

int Check(int size)
{
    int count = 0;
    for (int i = 1; i <= size; i++)
    {
        Console.Write($"Число {i}: ");
        int num = int.Parse(Console.ReadLine());
        if (num > 0) { count++; }
    }
    return count;
}

Console.WriteLine("Какое количество элементов хотите ввести? ");
int size = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество элементов больше 0 : {Check(size)}");

// int Check()
// {
//     int count = 0;
//     string word;

//     while (true)
//     {
//         Console.Write("Input any number: ");
//         word = Console.ReadLine();

//         if (word == "") { return count; }
//         else if (int.Parse(word) > 0) { count++; }
//     }
// }

// Console.WriteLine(Check());