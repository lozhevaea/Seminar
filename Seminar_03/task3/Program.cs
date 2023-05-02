// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

//Функция возведения в степень
// System.Console.WriteLine(Math.Pow(3, 3));
// System.Console.ReadLine();

//Функция извлечения квадратного корня
// System.Console.WriteLine(Math.Sqrt(16)); 
// System.Console.ReadLine();

//Функция округления числа
// System.Console.WriteLine(Math.Round(Math.Sqrt(27), 3));
// System.Console.ReadLine();

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int [] coordsA = new int [2];
coordsA[0] = ReadInt("Введите координату Х точки A: ");
coordsA[1] = ReadInt("Введите координату Y точки А: ");

int [] coordsB = new int [2];
coordsB[0] = ReadInt("Введите координату Х точки В: ");
coordsB[1] = ReadInt("Введите координату Y точки В: ");

// int [] coordsA = new int [2];

// System.Console.WriteLine("Введите координату Х точки A: ");
// coordsA[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки А: ");
// coordsA[1] = Convert.ToInt32(Console.ReadLine());

// int [] coordsB = new int [2];

// System.Console.WriteLine("Введите координату Х точки В: ");
// coordsB[0] = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату Y точки В: ");
// coordsB[1] = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(coordsA[0] - coordsB[0], 2) + Math.Pow(coordsA[1] - coordsB[1], 2));
System.Console.WriteLine(Math.Round(distance, 3));