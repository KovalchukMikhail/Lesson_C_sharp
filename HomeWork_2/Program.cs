// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

int Number(int num)
{
    int second = num / 10 % 10;
    return second;
}

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = Number(number);
Console.WriteLine($"Заданное число {number}, вторая цифра {result}");


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Number(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
        int third = num % 10;
    return third;
}

int check;
int number;
int result;
Console.Write("Введите целое число: ");
check = Convert.ToInt32(Console.ReadLine());
if (check < 0) number = check * (-1);
else number = check;
if (number < 100) Console.WriteLine($"Заданное число {check}, не имеет третьей цифры");
else{
    result = Number(number);
    Console.WriteLine($"Заданное число {check}, третья цифра {result}");
}

*/

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

bool DayWeek(int number)
{
    if (number == 6 || number == 7) return true;
    else return false;
}

int day;
bool weekend;
Console.Write("Введите номер дня недели: ");
day = Convert.ToInt32(Console.ReadLine());
if (day > 7 || day < 1) Console.Write($"Вы ввели число {day} такого дня недели нет");
else
{
    weekend = DayWeek(day);
    if (weekend == true) Console.Write($"День недели номер {day} выходной");
    else Console.Write($"День недели номер {day} рабочий");
}


