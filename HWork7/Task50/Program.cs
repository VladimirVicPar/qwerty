﻿// ## Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] FillArray(int m, int n)  // Метод создания двумерного массива
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)  // Метод печати двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int m, int n, int[,] array)  // Метод возврата искомого элемента массива
{
    if (array.GetLength(0) > m && array.GetLength(1) > n && m >= 0 && n >= 0)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (i == m && j == n) Console.WriteLine("Искомый элемент: " + array[i, j]);
            }
        }
    }
    else Console.WriteLine("Данного элемента нет");
}

int[,] array = FillArray(10, 10);
PrintArray(array);
Console.WriteLine("Веедите индекс строки: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Веедите индекс столбца: ");
int n = Convert.ToInt32(Console.ReadLine());
SearchElement(m, n, array);
