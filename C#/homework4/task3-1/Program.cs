// Задача *: Напишите программу, которая из массива случайных чисел. 
// Ищет второй максимум (число меньше максимального элемента, но больше всех остальных).
// Сделать одним циклом
// [1, 3, 5, 6, 6, 4] -> 5



int[] GenerateArray(int Length, int minRange, int maxRange)
{

    int[] Array = new int[Length];
    for (int index = 0; index < Array.Length; index++)
    {
        Array[index] = new Random().Next(minRange, maxRange + 1);
    }
    return Array;
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

int Length = Promt("Введите количество элементов массива-> ");
int minArray = Promt("Введите минимальный порог случайных значений-> ");
int maxArray = Promt("Введите максимальный порог случайных значений-> ");

int[] Array = GenerateArray(Length, minArray, maxArray);
PrintArray(Array);

int largest = int.MinValue;
int second = int.MinValue;
foreach (int i in Array)
{
    if (i > largest)
    {
        second = largest;
        largest = i;
    }
    else if (i > second && i < largest)
        second = i;
}

System.Console.WriteLine(second);