//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int CountPositive()
{
    int result = 0;
    int currentIndex = 1;
    string numbers = String.Empty;
    int currentNumber;
    string temp = String.Empty;
    while (true)
    {
        Console.Write($"Введите {currentIndex} число или 'n' для окончания ввода чисел: ");
        temp = Console.ReadLine();
        if (temp == "n" || temp == "N") break;
        currentNumber = Convert.ToInt32(temp);
        numbers = numbers + currentNumber + ", ";
        if (currentNumber > 0) result++;
        currentIndex++;
    }
    Console.WriteLine($"Введенные числа: {numbers}");
    return result;
}

int countPositiveNum = CountPositive();
Console.WriteLine($"Вы ввели {countPositiveNum} чисел(а) больше 0");
*/



// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double [] FindXAndY(double k1, double b1, double k2, double b2)
{
    double y = (b2 - k2*b1/k1) / (1 - k2/k1);
    double x = y/k1 - b1/k1;
    double [] result = {y, x};
    return result;
}

Console.WriteLine($"Для первой прямой заданной уровнением y = k1 * x + b1 ");
Console.Write("Введите значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Для второй прямой заданной уровнением y = k2 * x + b2 ");
Console.Write("Введите значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

double [] result = FindXAndY(k1, b1, k2, b2);
Console.WriteLine($"Точка пересечения двух прямых имеет координаты y = {result[0]}; x = {result[1]}");