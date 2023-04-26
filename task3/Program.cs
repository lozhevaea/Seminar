// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> среда
// 5 -> пятница

// Console.WriteLine("Введите номер: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1)
// {
//     Console.WriteLine("Its Monday");
// }
// else if (number == 2)
// {
//     Console.WriteLine("Its Tuesday");
// }
// else if (number == 3)
// {
//     Console.WriteLine("Its Wednesday");
// }
// else if (number == 4)
// {
//     Console.WriteLine("Its Thursday");
// }
// else if (number == 5)
// {
//     Console.WriteLine("Its Friday");
// }
// else if (number == 6)
// {
//     Console.WriteLine("Its Saturday");
// }
// else if (number == 7)
// {
//     Console.WriteLine("Its Sunday");
// }
// else
// {
//     Console.WriteLine("Error!!!");
// }

switch(number)

{
    case 1:
    {
    Console.WriteLine("Its Monday");
    break;
    }
    case 2:
    {
    Console.WriteLine("Its Tuesday");
    break;
    }
    case 3:
    {
    Console.WriteLine("Its Wednesday");
    break;
    }    
    case 4:
    {
    Console.WriteLine("Its Thursday");
    break;
    }    
    case 5:
    {
    Console.WriteLine("Its Friday");
    break;
    }    
    case 6:
    {
    Console.WriteLine("Its Saturday");
    break;
    }    
    case 7:
    {
    Console.WriteLine("Its Sunday");
    break;
    }   
    default:
    {
    Console.WriteLine("Error!!!");
    break;
    }
}