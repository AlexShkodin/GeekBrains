//Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A
// в натуральную степень B. Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write($"{message}");
    return Convert.ToInt32(System.Console.ReadLine());
}

int IntPow(int A, int B)
{
    int res = 1;
    while (B != 0)
    {
        if ((B & 1) == 1)
            res *= A;
        A *= A;
        B >>= 1;
    }
    return res;

}
int A = Prompt("Введите число A -> ");
int B = Prompt("Введите число B -> ");
System.Console.WriteLine($"Число {A} в степени {B} равно {IntPow(A, B)}");