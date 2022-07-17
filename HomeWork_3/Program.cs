// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*

bool IsPalindrome(int number, int size)
{
    bool result = true;
    int current = 1;
    int count = 1;
    while (count < size)
    {
        current = current * 10;
        count++;
    }
    count = 1;
    while (count <= size / 2 && result == true)
    {
        if (number / current == number % 10) result = true;
        else result = false;
        number = number % current / 10;
        current = current / 100;
        count++;
    }
    return result;
}

int SizeNumber(int number)
{
    int size = 1;
    while (number >= 10)
    {
        size++;
        number = number / 10;
    }
    return size;
}

int number;
int size;
bool palindrome;

Console.Write("Введите целое число: ");
number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = number * (-1);
size = SizeNumber(number);
palindrome = IsPalindrome(number, size);

if (palindrome == true) Console.Write("Введенное число является палиндромом");
else Console.Write("Введенное число НЕ является палиндромом");
*/


// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*

double Lenth(double xa, double ya, double za, double xb, double yb, double zb)
{
    double lenth = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya) + (zb - za) * (zb - za));
    return lenth;
}

Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки А: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки В: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Z точки В: ");
int zb = Convert.ToInt32(Console.ReadLine());


double lenth = Lenth(xa, ya, za, xb, yb, zb);
Console.Write($"Расточние между точками А и В равно {lenth}");
*/


// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*

void Numbers(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current*current*current + " ");
        current++;
    }
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);
*/