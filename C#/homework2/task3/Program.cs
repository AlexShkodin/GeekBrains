//  Задача 3: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет. Не использовать строки для расчета.
// 645 -> 5
// 78 -> третьей цифры нет
// 326792 -> 6

int Prompt(string message)
{
    System.Console.Write($"{message} >");
    int answer = Convert.ToInt32(Console.ReadLine());
    return answer;
}
bool ValidateNumber(int number)
{
    if (number >= 100)
    {
        return true;
    }

    System.Console.WriteLine("Здесь нет третьей цифры");
    return false;
}

int number = Prompt("Введите любое, но желательно трехзначное число");
if (ValidateNumber(number))
{
    string thirdNum = number.ToString();
    int[] arrInt = new int[thirdNum.Length];
    for (int n = 0; n < thirdNum.Length; ++n)
    {
        arrInt[n] = int.Parse(thirdNum[n] + "");
    }
    System.Console.WriteLine($"В веденном числе третьей цифрой является > {thirdNum[2]}");
}

// Не знал как решить иначе, решил преобразовать в строку)