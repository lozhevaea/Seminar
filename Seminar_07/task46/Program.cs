// Задайте двумерный массив размером m*n, заполненный случайными целыми числами.

// m = 3  n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col, int leftRange, int rightRange)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t"); 
        }
        System.Console.WriteLine();
    }
}

int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "), 0, 99);
PrintMatrix(matrix);

int[,] massiv = FillMatrix(2, 3, 0, 10);
PrintMatrix(massiv);

// int m = ReadInt("Введите количество строк: ");
// int n = ReadInt("Введите количество столбцов: ");

// int[,] matrix = new int[m, n]; // количество запятых говорит о многомерности массива
// Random rand = new Random();

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matrix[i,j] = rand.Next(-99, 100);
//     }
// }

// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         System.Console.Write(matrix[i, j] + "\t"); // знак табуляции выводит красиво матрицу чисел
//     }
//     System.Console.WriteLine();
// }

