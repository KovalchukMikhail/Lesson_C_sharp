
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
/*

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array =  CreateRandom2dArray(m, n, min, max);
Show2dArray(array);
*/

// Необходимо задать двумерный массив размером m на n каждый элемент в котором находится по формуле a[i, j] = i + j, и вывести полученый массив на экран
/*
int[,] CreateArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            newArray[i, j] = i + j;
        }

    }
    return newArray;
}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateArray(m, n);
Show2dArray(array);
*/


// Необходимо задать двумерный массив и найти в нем элементы у которых оба индекса четные и заменить эти элемнты на их квадраты
/*
int [,] ChangeArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i += 2)
    {
        for (int j = 0; j < array.GetLength(1); j += 2)
        {
            array[i, j] *= array[i, j];
        }

    }
    return array;
}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array =  CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

array =  ChangeArray(array);
Show2dArray(array);
*/

// Необходимо задать двумерный массив и найти сумму элементов находящихся на главной диагонали

int SumDiagonalNumber (int[,] array)
{
    int sumNumber = 0;
    for (int i = 0; i < array.GetLength(0) && i < array.GetLength(1); i++)
    {
        sumNumber += array[i, i];
    }
    return sumNumber;
}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array =  CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Console.WriteLine($"Сумма элементов расположенных на диагонали равна {SumDiagonalNumber (array)}");

// 