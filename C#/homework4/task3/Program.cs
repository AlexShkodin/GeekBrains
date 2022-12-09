// Задача 3: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный случайными числами. Оформите заполнение массива и вывод в виде функции
// (пригодится в следующих задачах). Реализовать через функции. 

int[] CreateArray(int length, int minRange, int maxRange)
{
    int[] numbers = new int[length];
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(minRange, maxRange + 1);
    }
    return numbers;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
    System.Console.WriteLine();
}

int length = 8;
int minValue = -999;
int maxValue = 999;

int[] arr = CreateArray(length, minValue, maxValue);
PrintArray(arr);

