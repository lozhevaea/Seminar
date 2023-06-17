// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежетке от 1 до N.

// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void Numbers(int N)
{
    if (N < 1) return;
    Numbers(N - 1);
    System.Console.Write(N + " ");  
    
}

Numbers(ReadInt("Введите значение N: "));