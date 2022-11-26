// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число > ");
int value1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число > ");
int value2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число > ");
int value3 = Convert.ToInt32(Console.ReadLine());

if (value1 > value2&&value1 > value3)
{
    System.Console.WriteLine($"Из введенных Вами чисел {value1} , {value2} , {value3} максимальным является {value1}");
}

else if (value2 > value1&&value2 > value3)
{
    System.Console.WriteLine($"Из введенных Вами чисел {value1} , {value2} , {value3} максимальным является {value2}");
}

else if (value3 > value1&&value3 > value2)
{
    System.Console.WriteLine($"Из введенных Вами чисел {value1} , {value2} , {value3} максимальным является {value3}");
}

else if (value1 == value2&&value2 == value3)
{
    System.Console.WriteLine($"Вы ввели три равных числа {value1} , {value2} , {value3}");
}

else 
{
    System.Console.WriteLine($"ТЫ ЧТО ТАКОЕ???");
}
