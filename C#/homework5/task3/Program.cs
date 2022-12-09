// Задача 3: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] array = new int[Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minRange, maxRange + 1);
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

int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int[] Multi(int[] Array)
{
    int[] result = new int[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        result[i] = Array[i] * Array[Array.Length - 1 - i];
    }
    return result;
}


int Length = Promt("Input length of array ");
int minArray = Promt("Input min of array ");
int maxArray = Promt("Input max of array ");

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
PrintArray(Multi(array));
// System.Console.WriteLine($"Count of numbers is {Multi(array)}");

