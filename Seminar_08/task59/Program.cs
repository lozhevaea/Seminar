// Задайте двумерный массив из целых чисел.Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

// 1 4 7 2 
// 5 9 2 3
// 8 4 2 4 
// 5 2 6 7 
// Наименьший эелемент - 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4 
// 2 6 7

void Main()
{
    Console.Clear();
    System.Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    System.Console.WriteLine("Начальная матрица: ");
    input_matrix(matrix);
    print_matrix(matrix);
    System.Console.WriteLine();
    FindMin(matrix);
   
}
void input_matrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10); // [1, 9]
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

void FindMin(int[,] matrix)
{
    int minRow = 0;
    int minCol = 0;
    int min = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < min)
            {
                minRow = i;
                minCol = j;
            }
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        if (i != minRow)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (j != minCol)
                {
                    System.Console.Write($"{matrix[i, j]} \t");    
                }
            }
        }
        System.Console.WriteLine();
    }
}
Main();