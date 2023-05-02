//  Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//Используем функцию для чтения числа с терминала

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

//Функция принимает на себя массив
void CheckQuarter(int[] coords, string[] str)
{
        if (coords[0] > 0 && coords[1] > 0)
    {
        System.Console.WriteLine(str[0]);
    }
    else if (coords[0] < 0 && coords[1] > 0)
    {
        System.Console.WriteLine(str[1]);
    }
    else if (coords[0] < 0 && coords[1] < 0)
    {
        System.Console.WriteLine(str[2]);
    }
    else if (coords[0] > 0 && coords[1] < 0)
    {
        System.Console.WriteLine(str[3]);
    }
    else
    {
        System.Console.WriteLine(str[4]);
    }
}

// Создаем массив с именем coords содержащий в себе 2 элемента
int[] coords = new int[2];

coords[0] = ReadInt("Введите координату точки X  ");
coords[1] = ReadInt("Введите координату точки Y  ");

// CheckQuarter(coords, str);

//Создаем строковый (текстовой) массив на 5 текстовых элементов
string[] str = {"Точка лежит в первой четверти", "Точка лежит во второй четверти", "Точка лежит в третьей четверти", "Точка лежит в четвертой четверти", "Точка лежит на одной из осей"};
CheckQuarter(coords, str);
// if (coords[0] > 0 && coords[1] > 0)
// {
//     System.Console.WriteLine(str[0]);
// }
// else if (coords[0] < 0 && coords[1] > 0)
// {
//     System.Console.WriteLine(str[1]);
// }
// else if (coords[0] < 0 && coords[1] < 0)
// {
//     System.Console.WriteLine(str[2]);
// }
// else if (coords[0] > 0 && coords[1] < 0)
// {
//     System.Console.WriteLine(str[3]);
// }
// else
// {
//     System.Console.WriteLine(str[4]);
// }





// //Функция сложения 2х чисел

// int SumNumbers (int num1, int num2)
// {
//     int sum = 0;
//     sum = num1 + num2;
//     return sum;
// }
// int a = 7;
// int b = 12;
// System.Console.WriteLine(SumNumbers(a, b));
