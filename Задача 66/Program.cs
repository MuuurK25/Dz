﻿// Задача 66: Задайте значения M и N. Напишите программу, которая
//  найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M:");
int numberM = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N:");
int numberN = int.Parse(Console.ReadLine());
void NumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    NumberSum(numberM, numberN, sum);
}
NumberSum(numberM, numberN, 0);