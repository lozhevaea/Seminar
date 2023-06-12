// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строки массива.
// Занятие не с Артемом.

void Main()
{
    System.Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    System.Console.WriteLine("Начальная матрица: ");
    input_matrix(matrix);
    print_matrix(matrix);
    System.Console.WriteLine("Конечная матрица: ");
    replase_string(matrix);
    print_matrix(matrix);
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

void replase_string(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0,j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
} 

Main();