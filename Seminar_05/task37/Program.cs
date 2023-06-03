// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

void Main()
{
    int size = 10;
    int[] arr = FillArray(size, 1, 10);
    PrintArray(arr);
    int[] newArr = CountPairs(arr, (size+1)/2);
    PrintArray(newArr);
}

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

int[] CountPairs(int[] arr, int size)
{
    int[] Array = new int[size];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        Array[i] = arr[i] * arr[arr.Length - 1 -i];
    }
    if (arr.Length % 2 == 1)
    {
        Array[Array.Length-1] = arr[arr.Length / 2];
    }
    return Array;
}

Main();
