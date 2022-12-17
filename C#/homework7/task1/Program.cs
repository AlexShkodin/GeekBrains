// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GenerateMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() + new Random().Next(-10, 10);
        }
    }
    return matrix;
}
void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(string.Format("{0:f2} \t", matrix[i, j]));
        }
        System.Console.WriteLine();
    }
}
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int lines = Promt("Введите количество строк ");
int columns = Promt("Введите количество столбцов ");

double[,] matrix = GenerateMatrix(new double[lines, columns]);
PrintMatrix(matrix);

