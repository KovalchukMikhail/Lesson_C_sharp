//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
double number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
double number2 = Convert.ToDouble(Console.ReadLine());

if (number1 > number2) Console.WriteLine("Первое число (number1 = " + number1 + ") больше чем второе число (number2 = " + number2 + ")");
if (number2 > number1) Console.WriteLine("Второе число (number2 = " + number2 + ") больше чем первое число (number1 = " + number1 + ")");
if (number2 == number1) Console.WriteLine("Числа равны (number1 = number2 = " + number1 + ")");


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

double number1, number2, number3, max;

Console.Write("Введите первое число: ");
number1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите второе число: ");
number2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите третье число: ");
number3 = Convert.ToDouble(Console.ReadLine());

max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.WriteLine("Наибольнее число " + max);


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("число " + number + " четное");
else Console.WriteLine("число " + number + " нечетное");


//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int current = 2;
string checkNumber;
int number;
Console.Write("Введите целое положительное число или введите 'no' для выхода: ");
checkNumber = Console.ReadLine();

if (checkNumber == "no") Console.WriteLine("До свидания");
else
{
    number = Convert.ToInt32(checkNumber);
    if (number < 2) Console.WriteLine("Вы ввели число меньше 2. Четных положительных чисел в заданном интервале нет.");
    while (current <= number)
    {
        Console.Write(current + " ");
        current = current + 2;
    }
}
*/
