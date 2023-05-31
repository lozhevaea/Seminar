// Напишите программу замена элементов массива: положительные элементы 
// замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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


void Cheng(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
    }
}


void PrintArray(int[]Array)
{
    System.Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

int[] Arr = FillArray(10, -9, 9);
PrintArray(Arr);
Cheng(Arr);
PrintArray(Arr);
