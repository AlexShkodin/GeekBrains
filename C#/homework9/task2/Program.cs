// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int PlusNatural(int M, int N)
{
    int sum = 0;
    sum = sum + M;
    if (M < N) return M + PlusNatural(M + 1, N);
    return sum;
}

Console.WriteLine($"{PlusNatural(Prompt("Введите M"), Prompt("Введите N"))}");