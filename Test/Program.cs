
/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 сиволам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекамендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] FillArray(int size)
{
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}

string[] ChangeArray(string[] array)
{
    int size = array.Length;
    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    for (int i = 0, j = 0; i < size; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] array)
{
    int size = array.Length;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.Write("Введите количество элементов массива: ");
string[] array = new string[Convert.ToInt32(Console.ReadLine())];

array = FillArray(array.Length);
Console.WriteLine("Заданный массив содержит следующие элементы:");
ShowArray(array);

string[] changedArray = ChangeArray(array);
Console.WriteLine("Результирующий массив содержит следующие элементы:");
ShowArray(changedArray);

