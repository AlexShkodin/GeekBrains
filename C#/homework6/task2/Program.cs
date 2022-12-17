// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

System.Console.WriteLine($"Программа найдёт точку пересечения двух прямых,\nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
double Input(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToDouble(System.Console.ReadLine());
}
System.Console.WriteLine($"Для решения задачи необходим ввод данных");
double b1 = Input("Введите значение b1");
double k1 = Input("Введите значение k1");
double b2 = Input("Введите значение b2");
double k2 = Input("Введите значение k2");
double Calculate(double x, double y)
{
    x = new double();
    y = new double();
    if (k1 * x + b1 == k2 * x + b2)
    {
        x = -(b1 - b2) / (k1 - k2);
        y = k2 * x + b2;
    }
}
Console.WriteLine($"{x},{y}");
