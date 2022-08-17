// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
/*
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangePositions(int[,] array, int row1, int row2)
{
    int temp = 0;
    for(int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[row1, j];
        array[row1, j] = array[row2, j];
        array[row2, j] = temp;
    }

    return array;
}

Console.Write("Введите номер строки 1: ");
int row1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки 2: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(5, 7, 0, 10);
Print2DArray(array);

if(row1 > array.GetLength(0) - 1 || row2 > array.GetLength(0) - 1) Console.WriteLine("Невозможно");
else
{
    ChangePositions(array, row1, row2);
    Print2DArray(array);
}
*/
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.
int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return newArray;
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++) Console.Write($"{array[i, j]} ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

//     // 1 2 3 4
//     // 5 7 8 9
//     // 0 9 8 2
//        1 2 5 7 

int[,] Reverse(int[,] array)
{
    int temp = 0;
    for(int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for(int j = i + 1; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }

    return array;
}  
Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимальный элемент: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимальный элемент: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array = CreateRandom2DArray(m, n, min, max);
Print2DArray(array); 

if(m != n) Console.WriteLine("Невозможно");
else 
{
    int[,] newArray = Reverse(array);
    Print2DArray(newArray);
}


// Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.
/*
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

int[,] ChangeArray(int[,] array)
{
    int indexI = 0;
    int indexJ = 0;
    int min = array[0, 0];
for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] <= min)
            {
                indexI = i;
                indexJ = j;
                min = array[i, j];
            }
        }
    }

    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    for (int i = 0, iForNewArray = 0; i < array.GetLength(0); i++, iForNewArray++)
    {
        if (i == indexI)
        {
            i++;
            if (i > array.GetLength(0) - 1) break;
        }
        for (int j = 0, jForNewArray = 0; j < array.GetLength(1); j++, jForNewArray++)
        {
            if (j == indexJ)
            {
                j++;
                if (j > array.GetLength(1) - 1) break;
            }
            newArray[iForNewArray, jForNewArray] = array[i, j];
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

int[,] array =  CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

Show2dArray(ChangeArray(array));
*/