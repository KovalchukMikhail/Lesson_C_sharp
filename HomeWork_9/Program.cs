// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
void ShowFromMToN(int numberM, int numberN)
{
    if (numberM < numberN)
    {
        if (numberM != numberN)
        {
            Console.Write($"{numberM} ");
            ShowFromMToN(numberM + 1, numberN);
        }
    }
    else if (numberM > numberN)
    {
        if (numberM != numberN)
        {
            Console.Write($"{numberM} ");
            ShowFromMToN(numberM - 1, numberN);
        }
    }
    else Console.Write($"{numberN} ");
}

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

ShowFromMToN(numM, numN);
*/

// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumbers(int numberM, int numberN)
{
        if (numberM != numberN) return numberM + SumNumbers(numberM + 1, numberN);
        else return numberN;
}

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

if (numM < numN) Console.WriteLine($"Sum numbers from M to N: {SumNumbers(numM, numN)}");
else Console.WriteLine($"Sum numbers from M to N: {SumNumbers(numN, numM)}");
*/



//  Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermannFunction (int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return AckermannFunction (numM - 1, 1);
    else return AckermannFunction (numM - 1, AckermannFunction (numM, numN - 1));
}

Console.Write("Input number M: ");
int numM = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The result counting Ackermann Function:{AckermannFunction(numM, numN)}");
