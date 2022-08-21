
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.
/*
void ShowNums(int n)
{
    if (n != 1) ShowNums(n - 1);

    Console.Write(n + " ");
}

Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNums(num);
*/

// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.

int SumOfDigits(int num)
{
    if (num != 0) return num % 10 + SumOfDigits(num / 10);
    return 0;
}


Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of digits in {num} is {SumOfDigits(num)}");


// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.




// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.



