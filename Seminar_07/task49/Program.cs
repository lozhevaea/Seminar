// Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, и замените эти элементы на их квадраты.

// 1 4 7 2        1 4 7 2 
// 5 9 2 3        5 81 2 9
// 8 4 2 4        8 4 2 4 

void Main()
{
    int[,] matrix = FillMatrix(ReadInt("Введите количество строк: "), ReadInt("Введите количество столбцов: "));
    PrintMatrix(matrix);
    System.Console.WriteLine();
    IndexPow(matrix);
    PrintMatrix(matrix);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
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

void IndexPow(int[,] matr)
{
    for (int i = 1; i < matr.GetLength(0); i+=2)
    {
        for (int j = 1; j < matr.GetLength(1); j+=2)
        {
            matr[i,j] = (int) Math.Pow(matr[i,j], 2);
            // matr[i,j] = matr[i,j] * matr[i,j];
            // matr[i,j] = Convert.ToInt32(Math.Pow(matr[i,j], 2);
        }
    }   
}

Main();