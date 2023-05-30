// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


void FillArray(int[] Array)
{
    Random rand = new Random();
    for (int i = 1; i < Array.Length; i++)
    {
        Array[i] = rand.Next(0, 2);
    }
}

void PrintArray(int[] Array)
{
    System.Console.WriteLine(string.Join(", ", Array));
}

int n = 8;
int[] arr = new int[n];
FillArray(arr);
PrintArray(arr);