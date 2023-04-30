// Напишите программу, которая выводит случайное число из отрезка [10, 99] и 
// показывает наибольшую цифру числа.

// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8

// Random rand = new Random();
// int number = rand.Next(10, 100);
// Выделяет новый экземпляр класса случайных чисел


int num = new Random().Next(10, 100);
//Console.WriteLine(num);
if (num/10 > num%10)
{
    System.Console.WriteLine($"{num} -> {num/10}");
}
else
{
    System.Console.WriteLine($"{num} -> {num%10}");
}