// Задача 23
// Напишите программу, которая принимает на вход число 
// (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.Clear();
Console.Write("Введите Ваше число: ");
int n = int.Parse(Console.ReadLine());
int z = 1;
while (z <= n)
{ 
  int kv = (z * z * z);
  z = z + 1; 
  Console.Write($"{kv}  ");
} 