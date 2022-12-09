//Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// Реализовать через функции.

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int input = Prompt("Введите число");

int Sum(int input)
{
    int result = 0;
    result += input % 10;
    input /= 10;
    if (input > 0)
    {
        result += Sum(input);
    }
    return result;

}
Console.WriteLine(Sum(input));