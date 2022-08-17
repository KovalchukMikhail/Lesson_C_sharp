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

// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
int[,] SortArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int currentIndex;
    int currentMax;
    for (int i = 0; i < rows; i++)
    {
        for (int maxIndex = 0; maxIndex < columns - 1; maxIndex++)
        {
            currentMax = array[i, maxIndex];
            currentIndex = maxIndex;
            for (int j = maxIndex + 1; j < columns; j++)
            {
                if (array[i, j] > currentMax)
                {
                    currentIndex = j;
                    currentMax = array[i, j];
                }
            }

            array[i, currentIndex] = array[i, maxIndex];
            array[i, maxIndex] = currentMax;

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

int[,] array = CreateRandom2dArray(m, n, min, max);
Show2dArray(array);

array = SortArray(array);
Show2dArray(array);
*/



// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int RowWithMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int sumMin = 0;
    int currentI = 0;
    for (int j = 0; j < columns; j++) sumMin += array[0, j];
    for (int i = 1; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        if (sum < sumMin)
        {
            sumMin = sum;
            currentI = i;
        }
    }
    return currentI;
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

Console.WriteLine($"Row with min sum has index {RowWithMinSum(array)}");
*/


// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] MultiplyArray (int[,] firstArray, int[,] secondArray)
{
    int rows = firstArray.GetLength(0);
    int columns = secondArray.GetLength(1);
    int[,] result = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            result[i, j] = firstArray[i, j] * secondArray[i, j];
        }
    }
    return result;
}

Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] arrayFirst = CreateRandom2dArray(m, n, min, max);
int[,] arraySecond = CreateRandom2dArray(m, n, min, max);
Console.WriteLine("First Array:");
Show2dArray(arrayFirst);

Console.WriteLine("Second Array:");
Show2dArray(arraySecond);

int[,] multArray = MultiplyArray (arrayFirst, arraySecond);
Console.WriteLine("Multiply first array by second array:");
Show2dArray(multArray);
*/

//  Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
int[,,] Create3dArray(int deeps, int rows, int columns, int minValue, int maxValue)
{
    bool changeNum = false;
    int[,,] array = new int[deeps, rows, columns];
    int num;
    for (int i = 0; i < deeps; i++)
    {
        for (int j = 0; j < rows; j++)
        {
            for (int k = 0; k < columns; k++)
            {
                changeNum = false;
                while(changeNum == false)
                {
                    num = new Random().Next(minValue, maxValue + 1);
                    changeNum = true;
                    for (int m = 0; m <= i; m++)
                    {
                        for (int n = 0; n < rows; n++)
                        {
                            for (int p = 0; p < columns; p++)
                            {
                                if (array[m,n,p] == num) changeNum = false;
                            }
                        }
                    }
                    if (changeNum == true) array [i,j,k] = num;
                }
            }
        }
    }
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
            Console.Write($"{array[i, j, k]}({i}{j}{k}) ");                
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

Console.Write($"Input number of deeps: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of rows: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int k = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,,] array = Create3dArray(m, n, k, min, max);
Show3dArray(array);
*/

// Заполните спирально массив 4 на 4.
/*
int[,] FillArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];
    int count = 1;
    newArray[0, 0] = count;
    int i = 0;
    int j = 0;
    string move = "right";
    while (count < rows * columns)
    {
        if (move == "right")
        {
            if (j + 1 < columns)
            {
                if (newArray[i, j + 1] == 0)
                {
                    j++;
                    count++;
                    newArray[i, j] = count;
                }
                else move = "down";
            }
            else move = "down";

        }
        if (move == "down")
        {
            if (i + 1 < newArray.GetLength(0))
            {
                if (newArray[i + 1, j] == 0)
                {
                    i++;
                    count++;
                    newArray[i, j] = count;
                }
                else move = "left";
            }
            else move = "left";

        }
        if (move == "left")
        {
            if (j - 1 >= 0)
            {
                if (newArray[i, j - 1] == 0)
                {
                    j--;
                    count++;
                    newArray[i, j] = count;
                }
                else move = "up";
            }
            else move = "up";
        }
        if (move == "up")
        {
            if (newArray[i - 1, j] == 0)
            {
                i--;
                count++;
                newArray[i, j] = count;
            }
            else move = "right";
        }
    }
    return newArray;
}



Console.Write($"Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(m, n);
Show2dArray(array);
*/
