// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число > ");
string inputValue1 = System.Console.ReadLine();
int value1 = Convert.ToInt32(inputValue1);

Console.Write("Введите второе число > ");
string inputValue2 = System.Console.ReadLine();
int value2 = Convert.ToInt32(inputValue2);

if (value1 > value2)
{
    System.Console.WriteLine($"Из введенных Вами чисел {value1} и {value2} максимальным является {value1}, а минимальным {value2}");
}
else if (value1==value2)
{
    System.Console.WriteLine($"Введенные Вами числа {value1} и {value2} равны");
}
else
{
    System.Console.WriteLine($"Из введенных Вами чисел {value1} и {value2} максимальным является {value2}, а минимальным {value1}");
}
