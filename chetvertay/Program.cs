// напишите программу, которая принимает на вход число (N) и 
// выдает таблицу квадратов чисел от 1 до N 
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4 
Console.Clear();
Console.Write("Введите Ваше число: ");
int n = int.Parse(Console.ReadLine());
int z = 1;
while (z <= n)
{ 
  int kv = (z * z);
  z = z + 1; 
  Console.Write($"{kv} ");
} 
// else {
//   Console.Write()
// }