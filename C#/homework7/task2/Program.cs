// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Ряд > 1
// Колонка > 7
// 1, 7 -> такого числа в массиве нет

int[,] GenerateMatrix(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];
    for (int y = 0; y < matrix.GetLength(0); y++)
    {
        for (int x = 0; x < matrix.GetLength(1); x++)
        {
            matrix[y, x] = new Random().Next(1, 10);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}
void SearchPosition(int[,] matrix, int linePosition, int colomnPosition)
{
    int linePos = linePosition - 1;
    int colomnPos = colomnPosition - 1;
    if (linePosition <= matrix.GetLength(0) && colomnPosition <= matrix.GetLength(1))
        System.Console.WriteLine($"Значение элемента в строке {linePosition} и столбце {colomnPosition} равно {matrix[linePos, colomnPos]}");
    else
        System.Console.WriteLine($"Элемента с такими параметрами нет в массиве!");
}
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int lines = Promt("Введите количество строк ");
int columns = Promt("Введите количество столбцов ");
int linePosition = Promt("Введите номер строки ");
int colomnPosition = Promt("Введите номер столбца ");
int[,] matrix = GenerateMatrix(lines, columns);
PrintMatrix(matrix);
SearchPosition(matrix, linePosition, colomnPosition);
