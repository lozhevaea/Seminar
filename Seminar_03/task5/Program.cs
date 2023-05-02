//Перевод буквы/символа char в целое число int возможно через строковый ковертёр. 

string? str = Console.ReadLine();
int  num = Convert.ToInt32(Convert.ToString(str![0]));
System.Console.WriteLine(num);

//узнать длину строкового массива
// string? str = Console.ReadLine();
// System.Console.WriteLine(str!.Length);