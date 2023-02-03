// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09

//double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Введите координаты первой точки X1 и Y1: ");
int X1 = int.Parse(Console.ReadLine() );
int Y1 = int.Parse(Console.ReadLine() );
Console.Write("Введите координаты второй точки X2 и Y2: ");
int X2 = int.Parse(Console.ReadLine() );
int Y2 = int.Parse(Console.ReadLine() );
double s = Math.Sqrt((X1-X2)^2 + (Y1-Y2)^2);
Console.WriteLine($"расстояние равно: {s}");
