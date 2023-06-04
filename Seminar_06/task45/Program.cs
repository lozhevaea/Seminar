// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


// int ReadInt(string text)
// {
//     System.Console.Write(text);
//     return Convert.ToInt32(Console.ReadLine());
// }

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

int[] CopyArray(int[] Arr)
{
    int[] copyArr = new int[Arr.Length];
    for (int i = 0; i < Arr.Length; i++)
    {
        copyArr[i] = Arr[i];
    }
    return copyArr;
}

// int[] arr = FillArray(5, 0, 10);
// int[] test = arr; //Память в данном случае под копию массива не выделяется
// arr[0] = 100;

// PrintArray(arr);
// PrintArray(test);

int[] arr = FillArray(5, 0, 10);
int[] test = arr[..]; //В данном случае под копию массива выделяется память.
arr[0] = 100;

PrintArray(arr);
PrintArray(test);

// // При использовании функции идет выделение новой памяти под копию массива
// int[] copy_arr = CopyArray(arr);
// PrintArray(copy_arr);