// Присутствует ли заданное число в массиве?

void Print(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(0, 11);
    }
    return arr;
}

void CheckNum(int[] arr, int n)
{
    string flag = "No";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] == n)
        {
            flag = "Yes";
        }
    }
    Console.WriteLine($"{n} -> {flag}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
CheckNum(arr_1,5);

