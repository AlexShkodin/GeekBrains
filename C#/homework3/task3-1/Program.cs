// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да
// * сделать программу универсальной(рабочей для любого числа)

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(System.Console.ReadLine());
}

int number = Prompt("Введите любое число");
int units = number % 10;
int dozens = (number / 10) % 10;
int hundreds = (number / 100) % 10;
int thousands = (number / 1000) % 10;
int tenthousand = (number / 10000) % 10;
int hundreds_of_thousands = (number / 100000) % 10;
int millions = (number / 1000000) % 10;
int tens_of_millions = (number / 10000000) % 10;
int hundreds_of_millions = (number / 100000000) % 10;
int billions = (number / 1000000000) % 10;

System.Console.WriteLine($"{units}, {dozens}, {hundreds}, {thousands}, {tenthousand}, {hundreds_of_thousands}, {millions}, {tens_of_millions}, {hundreds_of_millions}, {billions}");
// if (number > 100000000 && number < 1000000000)
// {
//     if (units == billions && dozens == hundreds_of_millions && hundreds == tens_of_millions && thousands == millions && tenthousand == hundreds_of_thousands)

//         System.Console.WriteLine($"{number} -> да");

//     else

//         System.Console.WriteLine($"{number} -> нет");


// }
// if (number > 10000000 && number < 100000000)
// {
//     if (units == hundreds_of_millions && dozens == tens_of_millions && hundreds == millions && thousands == hundreds_of_thousands)

//         System.Console.WriteLine($"{number} -> да");

//     else

//         System.Console.WriteLine($"{number} -> нет");

// }
//System.Console.WriteLine($"Число не пятизначное!");




