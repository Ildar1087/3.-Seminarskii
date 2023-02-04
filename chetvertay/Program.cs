// напишите программу, которая принимает на вход число (N) и 
// выдает таблицу квадратов чисел от 1 до N 
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4 
Console.Clear();
Console.Write("Введите Ваше число: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
if (N < 0)
{
  i = N;
  N = -1; // n = n * (-1);
}
for (; i <= N; i++)
{
  Console.Write($"{Math.Pow(i, 2)} ");
}