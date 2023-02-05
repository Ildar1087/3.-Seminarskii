// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
  array[i] = int.Parse(Console.ReadLine());
}
for (int j = 0; j < array.Length; j++)
{
  if (array[0] == array[4] && array[1] == array[3])
  {
    int s = array(j);
    Console.Write($"да, {s} палиндромное");
    return;
  }
  else
  {
    Console.Write($"число не палиндромное ");
    return;
  }
}