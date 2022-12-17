// Задача 5: * Найдите максимальное значение в матрице по каждой строке,
// получите сумму этих максимумов. Затем найдите минимальное значение по каждой колонке,
// получите сумму этих минимумов. Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

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
int Promt(String message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int lines = Promt("Введите количество строк ");
int columns = Promt("Введите количество столбцов ");

int[,] matrix = GenerateMatrix(lines, columns);
PrintMatrix(matrix);

