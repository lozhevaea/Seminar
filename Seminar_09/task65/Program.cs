// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void Main()
{
    int M = ReadInt("Введите значение M: ");
    int N = ReadInt("Введите значение N: ");
    if (M < N)
    {
        FindNumbers(M, N);
    }
    else
    {
        FindNumbers(N, M);
    }
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FindNumbers(int m, int n)
{
    if (m > n) return;
    System.Console.Write(m + " ");
    FindNumbers(m + 1, n);

}

Main();