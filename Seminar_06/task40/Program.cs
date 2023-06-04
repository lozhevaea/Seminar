// Напишите программу, которая будет принимать на вход три числа и проверять, 
// может ли существовать треугольник со сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

void Main()
{
    int A = ReadInt("Введите первое число: ");
    int B = ReadInt("Введите второе число: ");
    int C = ReadInt("Введите третье число: ");

if (Calculate(A, B, C))
{
    System.Console.WriteLine("Треугольник существует.");
}
else
{
    System.Console.WriteLine("Треугольник не существует");
}
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

bool Calculate(int N1, int N2, int N3)
{
    if (N1 < N2 + N3 && N2 < N1 + N3 && N3 < N2 + N3)
    return true;
    else return false;
}

Main();


// if (A < B + C && B < A + C && C < B + C)
// {
//     System.Console.WriteLine("Треугольник существует");
// }
// else
// {
//     System.Console.WriteLine("Треугольник не существует");
// }