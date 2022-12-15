// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int Prompt(string message)
{
    Console.Write($">{message} > "); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

int[] ToBinary(int Arg)
{
    int[] number = new int[8];
    int count = 1;
    while (Arg > 0)
    {
        int rem = Arg % 2;
        number[number.Length - count] = rem;
        count++;
        Arg = Arg / 2;
    }
    return number;
}

void PrintArray(int[] array)
{
    foreach (int number in array)
    {
        System.Console.Write($"{number}  ");
    }
}

int Arg = Prompt("Введите число");
PrintArray(ToBinary(Arg));