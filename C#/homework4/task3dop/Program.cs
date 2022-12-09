// (* Доп сложность, “введите количество элементов массива”, “Введите минимальный порог случайных значений”,
// “Введите максимальный порог случайных значений”)

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

int Length = Promt("Введите количество элементов массива-> ");
int minArray = Promt("Введите минимальный порог случайных значений-> ");
int maxArray = Promt("Введите максимальный порог случайных значений-> ");

int[] array = GenerateArray(Length, minArray, maxArray);
PrintArray(array);
