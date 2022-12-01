// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int N(string message)
{
    System.Console.Write($"{message}");
    int answer = Convert.ToInt32(System.Console.ReadLine());
    return answer;
}
int num = N("Чтобы получить таблицу кубов чисел от 1 до N, введите число N:");
int start = 1;
int modulNum = num;
if (modulNum < 0)
{
    modulNum = -(modulNum);
}

while (start <= modulNum)
{
    int cube = start*start*start;
    start += 1;
    System.Console.Write($"{cube}, ");
}
