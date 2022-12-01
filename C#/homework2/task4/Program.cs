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
switch (day)
{
    case 1:
        System.Console.Write($"{day} -> Нет");
        break;

    case 2:
        System.Console.Write($"{day} -> Нет");
        break;

    case 3:
        System.Console.Write($"{day} -> Нет");
        break;

    case 4:
        System.Console.Write($"{day} -> Нет");
        break;

    case 5:
        System.Console.Write($"{day} -> Нет");
        break;

    case 6:
        System.Console.Write($"{day} -> Да");
        break;

    case 7:
        System.Console.Write($"{day} -> Да");
        break;
    default:
        System.Console.WriteLine("В неделе всего семь дней");
        break;

}
