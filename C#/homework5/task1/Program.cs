// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GenerateArray(int Length)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write(array[j] + "\t");
    }
    Console.WriteLine();
}

int Search(int[] array)
{
    int counter = 0;
    foreach (int item in array)
    {
        if (item % 2 == 0)
        {
            counter++;
        }
    }
    return counter;
}

int[] array = GenerateArray(10);
PrintArray(array);
System.Console.WriteLine($"Количество чётных чисел в массиве {Search(array)}");