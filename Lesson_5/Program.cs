/*
int[] CreateArray(int size)
{
    int[] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} element of {size} ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] array = CreateArray(5);
ShowArray(array);
*/

// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for( int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

int SumOfPositive(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) sum += array[i];

    return sum;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write($"Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array =  CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine("Sum of positive elements is " + SumOfPositive(array));
*/

// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for( int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] InvertArray (int[] array)
{
    for (int i = 0; i < array.Length; i++) array[i] *= (-1);
    return array;
}

Console.Write($"Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array =  CreateRandomArray(size, min, max);
ShowArray(array);

array = InvertArray (array);
ShowArray(array);
*/


// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.




// Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int Count(int[] array, int min, int max)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= max && array[i] >= min) count++;
    }

    return count;
}


Console.Write($"Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, -1000, 1000);
ShowArray(array);

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());



Console.Write($"Колличество чисел в интервале от {min} до {max} равно {Count(array, min, max)}");
*/

// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;

}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] NewArray(int[] array)
{

    if (array.Length % 2 == 0)
    {
        int[] result = new int[array.Length / 2];
        for (int i = 0; i < result.Length; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        return result;
    }
    else
    {
        int[] result = new int[array.Length / 2 + 1];
        for (int i = 0; i < result.Length - 1; i++)
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        result[result.Length - 1] = array[result.Length - 1];
        return result;
    }

    
}

Console.Write($"Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write($"Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array =  CreateRandomArray(size, min, max);
ShowArray(array);

int[] result = NewArray(array);
ShowArray(result);