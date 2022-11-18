﻿// // Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int sumDigits(int number)
{
    int sum = 0;
    while (number / 10 != 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    return sum + number;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(sumDigits(number));