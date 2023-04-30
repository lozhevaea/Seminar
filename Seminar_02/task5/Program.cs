// Напишите программу, которая принимает на вход два числа и проверяет,
//  является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

System.Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

// if (a * a == b || b * b == a)
// {
//     System.Console.WriteLine("Да");
// }
// else
// {
//     System.Console.WriteLine("Нет");
// }

if (a * a == b)
{
    System.Console.WriteLine("Первое число является квадратом второго");
}
else if (b * b == a)
{
    System.Console.WriteLine("Второе число является квадратом первого");
}
else
{
    System.Console.WriteLine("Не является квадратом");
}