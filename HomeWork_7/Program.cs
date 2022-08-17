
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

double[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    double[,] newArray = new double[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();
        }
    }
    return newArray;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

double[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
*/



// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return newArray;

}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Console.Write($"Input index i: ");
int indexI = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input index j: ");
int indexJ = Convert.ToInt32(Console.ReadLine());

if(indexI < 0 || indexI >= m || indexJ < 0 || indexJ >= n) Console.WriteLine($"Element with indexs i = {indexI}, j = {indexJ} not exist");
else Console.WriteLine($"Element with indexs i = {indexI}, j = {indexJ}: {array[indexI, indexJ]}");
*/



// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }

    }
    return newArray;

}


void AverageColumns(int[,] array)
{
    double result;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        result = sum / array.GetLength(0);
        Console.WriteLine($"Average value of columns with index {j} : {result}");
    }
}


Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

AverageColumns(array);







