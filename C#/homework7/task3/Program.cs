// Задача 3. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrix(int m)
{
    int[,] matrix = new int[m, m];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j * 2;
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
void AwgColumns(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double awg = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            awg += matrix[i, j];
        }
        System.Console.Write($"{awg / matrix.GetLength(0):f2}\t");
    }

}

int[,] matrix = CreateMatrix(4);
PrintMatrix(matrix);
System.Console.WriteLine("Среднее арифметическое каждого столбца равно:");
AwgColumns(matrix);
