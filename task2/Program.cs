// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,] GenerateArray(int rows, int columns, int min, int max)
{
    int[,] answer = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            answer[i, j] = rnd.Next(min, max + 1);
        }
    }
    return answer;
}

void CheckPosition(int[,] array, int num1, int num2)  
{
    bool flag = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i + 1 == num1)   //проверяю номер позиции, а не индекса
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j + 1 == num2)         //проверяю номер позиции, а не индекса
                {
                    flag = true;
                    System.Console.WriteLine($"На позиции [{num1},{num2}] находится элемент {array[i, j]}");
                }
            }
        }
    }
    if (!flag) System.Console.WriteLine("Такого элемента нет.");
}

void PrintArray(int[,] array)
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

int rows = Prompt("Введите номер строки: ");
int columns = Prompt("Введите номер столбца: ");
int[,] binaryArray = GenerateArray(3, 4, 1, 9);
PrintArray(binaryArray);
CheckPosition(binaryArray, rows, columns);