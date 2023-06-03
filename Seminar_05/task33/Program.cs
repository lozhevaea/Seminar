// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, -3] -> да

void Main()
{
    int Num = ReadInt("Введите число для поиска: ");
    int[] arr = FillArray(5, 1, 10);
    PrintArray(arr);
    System.Console.WriteLine(CheckIfInArr(arr, Num));
}

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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

void PrintArray(int[] Array)
{
    System.Console.WriteLine("[" + string.Join(", ", Array) + "]");
}

bool CheckIfInArr(int[] arr, int num)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return true;
        }
     return false;
    }
}

Main();