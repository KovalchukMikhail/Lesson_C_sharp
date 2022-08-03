// Задача 1. Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*
int NumOfDigits(int num)
{
    int count = 0;

    while (num != 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = NumOfDigits(number);

Console.WriteLine($"Number of digits of {number} is {result}");
*/
// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int SumNumber(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumNumber(number);

Console.WriteLine($"Сумма чисел от 1 до {number} равна {result}");
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N, кратных трем.
/*
int ResNumber(int num)
{
    int result = 1;
    for (int i = 3; i <= num; i += 3)
    {
        result *= i;
    }
    return result;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 3) Console.WriteLine("Число меньше 3");
else
{
    int result = ResNumber(number);

    Console.WriteLine($"Произведение чисел от 1 до {number} кратных 3 равно {result}");
}
*/

// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

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

int[] binarayArray = CreateRandomArray (10, 0, 5);
ShowArray(binarayArray);