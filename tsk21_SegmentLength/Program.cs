/* Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

// Функция ввода координат точек
int EnterPoint(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = EnterPoint("Enter the x coordinate of point 1: ");
int y1 = EnterPoint("Enter the y coordinate of point 1: ");
int z1 = EnterPoint("Enter the z coordinate of point 1: ");
int x2 = EnterPoint("Enter the x coordinate of point 2: ");
int y2 = EnterPoint("Enter the y coordinate of point 2: ");
int z2 = EnterPoint("Enter the z coordinate of point 2: ");

int X = x2 - x1;
int Y = y2 - y1;
int Z = z1 - z2;

double length = Math.Round(Math.Sqrt(X * X + Y * Y + Z * Z),2);
Console.WriteLine($"The length of the segment is {length}");