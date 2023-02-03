// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int X = int.Parse(Console.ReadLine());
int Y = int.Parse(Console.ReadLine());
if(X>0&&Y>0)
{
    Console.WriteLine("{X} и {Y} больше нуля ");
}
if(X<0&&Y>0)
{
    Console.WriteLine("2");
}
if(X<0&&Y<0)
{
    Console.WriteLine("3");
}
if(X>0&&Y<0)
{
    Console.WriteLine("4");
}
if (X == 0 || Y == 0)
    Console.WriteLine("На оси");