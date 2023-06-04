// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 3 -> 11
// 2 -> 10
// 44 -> 101100

void Main()
{
    int N = ReadInt("Введите число: ");
    // ConvertToBinary(N);
    string str = Convert.ToString(N, 2);
    System.Console.WriteLine(str);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

void ConvertToBinary(int N)
{
    if (N <= 0)
    {
        return;
    }
    ConvertToBinary(N / 2); // если поменять местами 27 и 28 строки, то будет печатать в обратном порядке.
    System.Console.Write(N % 2);
}

Main();