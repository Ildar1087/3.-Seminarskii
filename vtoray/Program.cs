// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int n = int.Parse(Console.ReadLine());
int X, Y;
if(n == 1)
{
    Console.WriteLine("X>0 и Y>0");
}
if(n == 2)
{
    Console.WriteLine("X<0 и Y>0");
}
if(n == 3)
{
    Console.WriteLine("X<0 и Y<0");
}
if(n == 4)
{
    Console.WriteLine("X>0 и Y<0");
}
if (n <= 0 || n > 4)
{
 Console.WriteLine("введена не правильная четверть");
}