// Не используя рекурсию, выведите первые N чисел Фибоначчи.
// Первые два числа Фибоначчи: 0 и 1.

// Если N = 3 -> 0 1 1
// Если N = 5 -> 0 1 1 2 3
// Если N = 7 -> 0 1 1 2 3 5 8

void Main()
{
    PrintFibonachi(ReadInt("Введите число элементов функции Фибоначчи: "));
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintFibonachi(int num)
{
    System.Console.Write("0 1 ");
    int A  = 0;
    int B = 1;
    for (int i = 0; i < num-2; i++)
    {
        int res = A + B;
        System.Console.Write(res + " ");
        A = B;
        B = res;
    }
}

Main();