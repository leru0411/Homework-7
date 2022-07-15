﻿// Задача 1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

double[,] GenerateArray(int rows, int columns, int min, int max)
{
    double[,] answer = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = Math.Round(rnd.Next(min, max) + rnd.NextDouble(), 2);
        }
    }
    return answer;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
    }
    System.Console.WriteLine();
}

int r = Prompt("Введите количество строк: ");
int c = Prompt("Введите количество столбцов: ");
double[,] binaryArray = GenerateArray(r, c, 1, 10);
PrintArray(binaryArray);
