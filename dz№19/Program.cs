// Задача 19

// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()); 
Console.Clear();
int res1 = (num / 10000);
int res11 = ((num /1000)%10);
int res2 = num % 10;
int res22 = ((num % 100)/10);
if (res1 == res2 && res11 == res22)
{
Console.WriteLine($"да, {num} палиндромное число");
}
else
{ 
Console.WriteLine($"нет, число {num} не палиндромное");
}