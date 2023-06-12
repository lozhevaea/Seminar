// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозмозно, программа должна вывести сообщение для пользователя.

void Main()
{
    Console.Clear();
    System.Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    System.Console.WriteLine("Начальная матрица: ");
    input_matrix(matrix);
    print_matrix(matrix);
    System.Console.WriteLine("Конечная матрица: ");
    if (TransponMatrix(matrix))
    print_matrix(matrix);
    else System.Console.WriteLine("Матрица не квадратная.");
    
}

void input_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 11); // [-10, 10]
        }
    }
}

void print_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} \t");
        }
        System.Console.WriteLine();
    }
}

// void TransponMatrix(int[,] matrix)
// {
//     if (matrix.GetLength(0) != matrix.GetLength(1))
//     {
//         System.Console.WriteLine("Матрица не квадратная.");
//     }
//     else
//     {
//         int buffer = 0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = i + 1; j < matrix.GetLength(1); j++)
//             {
//                 buffer = matrix[i, j];
//                 matrix[i, j] = matrix[j, i];
//                 matrix[j, i] = buffer;
//             }
//         }
        
//     }
// }

bool TransponMatrix(int[,] matrix)
{
    if (matrix.GetLength(0) != matrix.GetLength(1))
    {
        return false;
    }
    else
    {
        int buffer = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = i + 1; j < matrix.GetLength(1); j++)
            {
                buffer = matrix[i, j];
                matrix[i, j] = matrix[j, i];
                matrix[j, i] = buffer;
            }
        }
        return true;
    }
}

Main();