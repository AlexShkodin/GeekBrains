// 2. Напишите программу, которая выводит 
//случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8 
// 12-> 2 
// 85 -> 8

int random = new Random(). Next(10,100);
System.Console.WriteLine(random);

int ed = random%10;
int des = random/10;

if (ed > des)
{
    System.Console.WriteLine(ed);
}
else
{
    System.Console.WriteLine(des);
}
