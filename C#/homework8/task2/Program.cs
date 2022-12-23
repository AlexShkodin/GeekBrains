// Задача 2: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

int Prompt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int rows = Prompt("Введите количество строк в массиве");
int cols = Prompt("Введите количество стобцов в массиве");

int[,] GenerateMatrix()
{
    int[,] matrix = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] FindMinSummString(int[,] matrix)
{
    int[] rowSum = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum[i] += matrix[i, j];
        }
    }
    return rowSum;
    
}

int[,] random_matrix = GenerateMatrix();
PrintMatrix(random_matrix);
int[] min_string = FindMinSummString(random_matrix);
System.Console.WriteLine($"Номер строки с наименьшей суммой элементов: {min_string} строка");