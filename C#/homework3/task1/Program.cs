// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом. Не использовать строки
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Prompt(string message)
{
    System.Console.WriteLine($"{message}");
    return Convert.ToInt32(System.Console.ReadLine());
}

int number = Prompt("Введи число");
int units = number % 10;
int dozens = (number / 10) % 10;
int thousands = (number / 1000) % 10;
int tenthousand = number / 10000;

if (number > 10000 && number < 100000)
{
    if (units == tenthousand && dozens == thousands)
    {
        System.Console.WriteLine($"{number} -> да");
    }
    else
    {
        System.Console.WriteLine($"{number} -> нет");
    }
}
else
    System.Console.WriteLine($"Число не пятизначное!");




