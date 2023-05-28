// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountNambers(int A)
{
    int sum = 0;
    while (A != 0)
    {
        A /= 10;
        sum += 1;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
System.Console.WriteLine(CountNambers(A));