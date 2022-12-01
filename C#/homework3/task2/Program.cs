// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Insert(string message)
{
    Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}
int xA = Insert("Введите координату x точки A");
int yA = Insert("Введите координату y точки A");
int zA = Insert("Введите координату z точки А");
int xB = Insert("Введите координату x точки B");
int yB = Insert("Введите координату y точки B");
int zB = Insert("Введите координату z точки B");
int deltax = xA - xB;
int deltay = yA - yB;
int deltaz = zA - zB;
double distance = Math.Sqrt(deltax * deltax + deltay * deltay + deltaz * deltaz);
System.Console.WriteLine($"A({xA},{yA},{zA}); B({xB},{yB},{zB}) -> {distance:f2}");