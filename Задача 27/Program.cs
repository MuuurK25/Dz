﻿// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int n = number;
int sum = 0;
while (n > 0)
{
int num = n % 10;
n = n / 10;
sum = sum + num;
}
Console.WriteLine($"Сумма всех цифр числа {number} равна: {sum}");
