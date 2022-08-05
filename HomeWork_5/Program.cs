
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) count++;

    return count;
}


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

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int min = 100;
int max = 1000;

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine($"В массиве {CountNumber(array)} четных чисел(а)");
*/


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
int SumNumber(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2) sum += array[i];
    return sum;
}


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

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимально возможное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимально возможное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine($"Сумма элементов массива стоящих на нечетных позициях ровна: {SumNumber(array)}");

*/


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double differenceMaxMin(double[] array)
{
    double result;
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    result = max - min;
    return result;
}

double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] newArray = new double[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1) * new Random().NextDouble();
    }
    return newArray;

}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите минимально возможное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите максимально возможное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomArray(size, min, max);
ShowArray(array);

Console.WriteLine($"Разность между максимальным и минимальным значениями элементов массива равна: {differenceMaxMin(array)}");



