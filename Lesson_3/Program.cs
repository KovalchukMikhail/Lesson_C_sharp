// Задача 1. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void ShowDiaposon(int quart)
{
    if(quart>=1 && quart<=4)
    {
        if (quart == 1) Console.WriteLine("x > 0, y > 0");
        if (quart == 2) Console.WriteLine("x < 0, y > 0");
        if (quart == 3) Console.WriteLine("x < 0, y < 0");
        if (quart == 4) Console.WriteLine("x > 0, y < 0");
    }
    else Console.WriteLine("Uncorrect input!");
}
*/

// Задача 2. Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int Number(int x, int y)
{
    int result = 0;
    if (x > 0 && y > 0) result = 1;
    if (x < 0 && y > 0) result = 2;
    if (x < 0 && y < 0) result = 3;
    if (x > 0 && y < 0) result = 4;
    return result;
}

Console.Write("Введите значение координаты Х: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int number;
if (x != 0 && y != 0)
{
    number = Number(x, y);
    Console.Write($"Точка относится к {number} четверти");
}
else Console.WriteLine("Точка находится на оси кординат");
*/



// Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
/*
double Lenth(double xa, double ya, double xb, double yb)
{
    double lenth = Math.Sqrt((xb - xa) * (xb - xa) + (yb - ya) * (yb - ya));
    return lenth;
}

Console.Write("Введите значение координаты Х точки А: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки А: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Х точки В: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение координаты Y точки В: ");
int yb = Convert.ToInt32(Console.ReadLine());

double lenth = Lenth(xa, ya, xb, yb);
Console.Write($"Расточние между точками А и В равно {lenth}");
*/


// Задача 4. Напишите программу, которая принимает на вход число (N) и выдаёт последовательность квадратов чисел от 1 до N.
/*
void Numbers(int num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current*current + " ");
        current++;
    }
}

Console.Write("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);

*/

void Numbers(double num)
{
    int current = 1;
    while (current <= num)
    {
        Console.Write(current*current + " ");
        current++;
    }
}

double check;
Console.Write("Введите число: ");
check = Convert.ToDouble(Console.ReadLine());
if (check < 0) check = check * (-1);
Numbers(check);
