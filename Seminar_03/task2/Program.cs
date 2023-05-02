// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите номер четверти: ");
int N = Convert.ToInt32(Console.ReadLine());

string[] array = {"x > 0, y > 0", "x < 0, y > 0", "x < 0, y < 0", "x > 0, y < 0", "Введено неверное число"};


if (N == 1)
{
    System.Console.WriteLine(array[0]);
}
else if (N == 2)
{
    System.Console.WriteLine(array[1]);
}
else if (N == 3)
{
    System.Console.WriteLine(array[2]);
}
else if (N == 4)
{
    System.Console.WriteLine(array[3]);
}
else
{
    System.Console.WriteLine(array[4]);
}