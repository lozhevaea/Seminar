// Напишите программу, которая на вход принимает два числа и проверяет, является ли 
//первое число квадратом второго.

// а = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if(a == b * b)
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число НЕ является квадратом второго");
}