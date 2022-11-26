// 4.1. Напишите программу, которая генерирует несколько случайных чисел,
// и в цикле проверяет, кратны ли эти числа предварительно введенному числу, при кратности - цикл прерывается.
// Введенное число 2
// 13 -> нет 
// 15 -> нет 
// 12 -> да

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int div = Prompt ("Делитель = ");

// int Random()
// {
//     int number = new Random().Next(0,10);
//     return number;
// }


while (true)
{
    int value = new Random().Next(0,10);
    Console.WriteLine(value);
    if (value % div == 0)
    {
        Console.WriteLine($"Мы нашли делитель, это - {value}");
        break;
    }
}
