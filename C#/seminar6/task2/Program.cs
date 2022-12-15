// Задача 1: Напишите программу, которая принимает на вход три числа и проверяет,
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int Prompt(string message)
{
    Console.Write($">{message} > "); // Вывод приглашения
    return Convert.ToInt32(Console.ReadLine()); // ввод числа
}

bool CeckSides(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A)
    {
        return true;
    }
    return false;
}

int A = Prompt("Введите длину первой стороны");
int B = Prompt("Введите длину второй стороны");
int C = Prompt("Введите длину третьей стороны");
if (CeckSides(A, B, C))
{
    System.Console.WriteLine("yes");
}
else
{
    System.Console.WriteLine("no");
}
