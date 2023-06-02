// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
// значения которых лежат в отрезке [10,99]. 

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] Array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        Array[i] = rand.Next(leftRange, rightRange + 1);
    }
    return Array;
}

void PrintArray(int[]Array)
{
    System.Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

int CountElem(int[] Array)
{
    int count = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] >= 10 && Array[i] <= 99)
        {
            count++;
        }
    }
    return count;
}

int[] arr = FillArray(10, -90, 100);
PrintArray(arr);
System.Console.WriteLine($"Количество чисел, входящих в диапазон от 10 до 99: {CountElem(arr)}");