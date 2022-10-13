﻿// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет



int[,] matrix = new int[3, 4];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(-10, 100);
        Console.Write($"{matrix[i, j]} ");

    }
    Console.WriteLine();
}


Console.WriteLine();

Console.WriteLine("Введите индекс строки: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите индекс столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a < matrix.GetLength(0))
{
    if (b < matrix.GetLength(1))

    {
        Console.WriteLine(matrix[a, b]);
    }
    else
    {
        Console.WriteLine("");
    }
}
