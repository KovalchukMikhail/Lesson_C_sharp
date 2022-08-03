// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
int Degree(int firstNum, int secondNum)
{
    int result = 1;
    for (int i = 0; i < secondNum; i++) result *= firstNum;
    return result;
}

Console.Write("Введите первое целое число(возводимое в степень): ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите втрое целое число больше 0 (степень): ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if(secondNumber > 0)
{
    int result = Degree(firstNumber, secondNumber);
    Console.WriteLine($"число {firstNumber} в степени {secondNumber} равно {result}");
}
else Console.WriteLine("Введенное число (степень) меньше 1");
*/

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SumNum(int num)
{
    int result = 0;
    if (num < 0) num *= (-1);

    while (num >= 10)
    {
        result += num % 10;
        num /= 10;
    }
    result += num;
    return result;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = SumNum(number);

Console.WriteLine($"Сумма цифр числа {number} равна {sum}");
*/

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

double[] NewArray(int size)
{
    double[] array = new double [size];
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    Console.WriteLine("Все элементы массива введены");
    return array;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
double[] array = new double[Convert.ToInt32(Console.ReadLine())];

array = NewArray(array.Length);
Console.WriteLine("Значения элементов массива:");
ShowArray(array);
