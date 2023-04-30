// Напишите программу, которая выводит случайное трехзначное число и 
// удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = new Random().Next(100, 1000);
System.Console.WriteLine(num);
// int a = num / 100;
// int b = num % 10;
// int c = a * 10 + b;
// System.Console.WriteLine(c);

System.Console.WriteLine($"{num/100}{num%10}");