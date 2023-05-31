// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,
//  сумма отрицательных равна -20.

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

void SumNegativeAndPositive(int[] arr, out int sumNegative, out int sumPositive)
{
    sumNegative = 0;
    sumPositive = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPositive += arr[i];
        }
        else
        {
            sumNegative += arr[i];
        }

    }
}
int[] Arr = FillArray(12, -9, 9);
PrintArray(Arr);
SumNegativeAndPositive(Arr, out int sumN, out int sumP);
System.Console.WriteLine($"Сумма положительных: {sumP}");
System.Console.WriteLine($"Сумма отрицательных: {sumN}");

//Другой способ
// int SumNegativeAndPositive(int[] arr)
// {
//     int[] posAndNeg = new int[2];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0)
//         {
//             posAndNeg[0] += arr[i];
//         }
//         else
//         {
//             posAndNeg[1] += arr[i];
//         }
//     }
//     return posAndNeg;
// }