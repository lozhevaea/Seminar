// Составить частотный словарь элементов двумерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// {1, 9, 9, 0, 2, 8, 0, 9}
// 0 встречается 2 раза
// 1 встречается 1 раз
// 2 встречается 1 раз
// 8 встречается 1 раз
// 9 встречается 3 раза

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6
// 1 встречается 3 раза
// 2 встречается 2 раза
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

void Main()
{
    Console.Clear();
    System.Console.Write("Введите размер матрицы: ");
    int[] size = Console.ReadLine()!.Split(" ").Select(x => int.Parse(x)).ToArray();
    int[,] matrix = new int[size[0], size[1]];
    int[] array = new int[size[0] * size[1]];
    System.Console.WriteLine("Начальная матрица: ");
    int size_arr = 0;
    InputMatrix(matrix, array, ref size_arr);
    PrintMatrix(matrix);
    System.Console.WriteLine();
     System.Console.WriteLine("[" + string.Join(", ", array) + "]");
    MatrixCount(array, matrix, size_arr);
}

void InputMatrix(int[,] matrix, int[] arr, ref int index_arr)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            if (CheckArray(arr, matrix[i,j], index_arr))
            {
                arr[index_arr] =  matrix[i, j];
                index_arr++;
            }
            
        }
    }
}

void PrintMatrix(int[,] matrix)
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

bool CheckArray(int[] Array, int number, int index_array)
{
    for (int i = 0; i < index_array + 1; i++)
    {
        if (Array[i] == number)
        {
            return false;
        }
        
    }
    return true;
}

void MatrixCount(int[] array, int[,] matrix, int size_arr)
{
    for (int k = 0; k < size_arr; k++)
    {
        int count = 0;
        for (int i = 0;  i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i,j] == array[k])
                {
                    count++;
                }
            }
        }
        System.Console.WriteLine($"Элемент {array[k]} встречается {count} раз");
    }
}
Main();