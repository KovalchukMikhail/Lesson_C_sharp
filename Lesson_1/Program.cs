/* Task 1
double num1, num2;

Console.Write("Input first integer number: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second integer number: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 == num2 * num2)
    Console.WriteLine("Yes");
else
    Console.WriteLine("No");


// Task 2
Console.Write("Input positive integer number: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num)
{
    Console.Write(current + " ");
    current++;
}
*/

string exit;
int numberDay = 0;
bool test = false;
while(test == false)
{
    Console.WriteLine("Input number from 1 before 7 or 'no' for exit");
    exit = Console.ReadLine();
    if(exit == "no")
    {
        Console.WriteLine("Goodbye");
        break;
    }
    numberDay = Convert.ToInt32(exit);
    if(numberDay > 0 && numberDay < 8) test = true;
}


if(numberDay == 1) Console.WriteLine("Monday");
if(numberDay == 2) Console.WriteLine("Tuesday");
if(numberDay == 3) Console.WriteLine("Wednesday");
if(numberDay == 4) Console.WriteLine("Thursday");
if(numberDay == 5) Console.WriteLine("Friday");
if(numberDay == 6) Console.WriteLine("Saturday");
if(numberDay == 7) Console.WriteLine("Sunday");



