// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


//Решение через функции

// void Main()
// {
//     int Num = ReadInt("Введите число: ");
//     System.Console.WriteLine(B(Num));
// }

// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

// int B(int N)
// {
//     int factorial = 1;
//     for (int i = 1; i <= N; i++)
//     {
//         factorial *= i;
//     }
//     return factorial;
// }

// Main();



// Решение через рекурсивную функцию

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int CountFact(int N)
{
    if(N == 1)
        return 1;
    return N * CountFact(N - 1);
}

int Num = ReadInt("Введите число: ");
System.Console.WriteLine(CountFact(Num));