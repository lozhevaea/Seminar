//Напишите программу, которая перевернет одномерный массив. 

// [1, 2, 3, 4, 5] -> [5, 4, 3, 2, 1]
// [6, 3, 4, 6] -> [6, 4, 3, 6]

void Main()
{
    int[] array = FillArray(ReadInt("Введите размер масства: "), 0, 10);
    PrintArray(array);
    ReverceArray(array);
    PrintArray(array);
}

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine(string.Join(" ", arr));
}

void ReverceArray(int[] Array)
{
    int temp = 0;
    for (int i = 0; i < Array.Length / 2; i++)
    {
        temp = Array[i];
        Array[i] = Array[Array.Length - 1 - i];
        Array[Array.Length - 1 - i] = temp;
    }
}

Main();

// System.Console.WriteLine("Введите размер массива: ");
// int arrLend = Convert.ToInt32(Console.ReadLine());

// int[] arr = new int[arrLend];
// Random rand = new Random();

// for (int i = 0; i < arrLend; i++)
// {
//     arr[i] = rand.Next(0, 10);
// }

// System.Console.WriteLine(string.Join(" ", arr));

// int temp = 0;
// for (int i = 0; i < arrLend / 2; i++)
// {
//     temp = arr[i];
//     arr[i] = arr[arrLend - 1 - i];
//     arr[arrLend - 1 - i] = temp;
// }

// System.Console.WriteLine(string.Join(" ", arr));