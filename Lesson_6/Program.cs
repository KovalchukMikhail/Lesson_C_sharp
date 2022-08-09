// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
*/

// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
/*
bool CheckTriangle (int a, int b, int c)
{
    return a < b + c && b < a + c && c < a + b;
}

Console.Write($"Введите длину первой стороны треугольника: ");
int lengthA = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите длину второй стороны треугольника: ");
int lengthB = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите длину третьей стороны треугольника: ");
int lengthC = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CheckTriangle (lengthA, lengthB, lengthC));
*/


// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
/*
string Conv(int number)
{
    string result = String.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /= 2;
    }
    return result;
}

Console.Write("Введите число для преобразование: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" число {number} в двоичной системе равно {Conv(number)}");
*/
// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int [] Fibonachy (int n, int numFirst, int numSecond)
{
    int [] result = new int [n];
    result[0] = numFirst;
    result[1] = numSecond;
    for (int i = 2; i < n; i++) result[i] = result[i - 1] + result [i - 2];
    return result;
}

Console.Write("Введите первое число Фибоначи: ");
int numFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число Фибоначи: ");
int numSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел Фибоначи которое необходимо вывести ");
int Count = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibonachy(Count, numFirst, numSecond));

