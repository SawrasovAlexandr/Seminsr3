﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да


Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num >= 10000 && num <= 99999)
{
Console.Write((num / 10000 == num % 10) && (num / 1000 % 10 == num / 10 % 10) ? "Является полиндромом" : "Не является полиндромом");
}
else Console.Write("Введенное выражение не является пятизначным числом");