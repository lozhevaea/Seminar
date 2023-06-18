// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

// 453 -> 12
// 45 -> 9

int SumNumbers(int n)
{
    if (n == 0) return 0;
    return n%10 + SumNumbers(n/10);
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

System.Console.WriteLine(SumNumbers(ReadInt("Введите число: ")));