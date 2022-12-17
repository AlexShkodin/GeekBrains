// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine($"Эта программа будет проверять сколько чисел больше 0 Вы ввели!\n");
Console.Write($"Введите количество элементов массива:");
int elementsCount = int.Parse(Console.ReadLine());
int[] array = new int[elementsCount];

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write($"Введите элемент массива под индексом {i} -> ");
    array[i] = int.Parse(System.Console.ReadLine());
}

Console.WriteLine("Благодарю за введенные данные!");
Console.Write("Вот полученный массив: ");

for (int i = 0; i < array.Length; i++)
{
    Console.Write($" {array[i]}  ");
}

Console.WriteLine($"\nКоличество положительных элементов в данном массиве: {array.Where(i => i > 0).Count()}");

