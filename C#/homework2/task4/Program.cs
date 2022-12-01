//  Задача 4: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Day(string message)
{
    System.Console.Write($"{message}");
    int dayNumber = Convert.ToInt32(System.Console.ReadLine());
    return dayNumber;
}
int day = Day("Введите день недели > ");
// switch (day)   так тоже работает, но условий много
// {
//     case 1:
//         System.Console.Write($"{day} -> Нет");
//         break;

//     case 2:
//         System.Console.Write($"{day} -> Нет");
//         break;

//     case 3:
//         System.Console.Write($"{day} -> Нет");
//         break;

//     case 4:
//         System.Console.Write($"{day} -> Нет");
//         break;

//     case 5:
//         System.Console.Write($"{day} -> Нет");
//         break;

//     case 6:
//         System.Console.Write($"{day} -> Да");
//         break;

//     case 7:
//         System.Console.Write($"{day} -> Да");
//         break;
//     default:
//         System.Console.WriteLine("В неделе всего семь дней");
//         break;

// }
if (day > 0 && day <= 5)
    System.Console.Write($"{day} -> Нет");
else if (day >= 6 & day <= 7)
    System.Console.Write($"{day} -> Да");
else
    System.Console.Write($"{day}? -> В неделе всего семь дней");