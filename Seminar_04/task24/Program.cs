//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36


// System.Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// for (int i = 1; i <= A; i++)
// {
//     sum+=i; //sum = sum + i;
// }
// System.Console.WriteLine(sum);



//Решение через функции

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int Sumnambers(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i; //sum = sum + i;
    }
    return sum;
}

int A = ReadInt("Введите число: ");
int sum = Sumnambers(A);
System.Console.WriteLine(sum);
