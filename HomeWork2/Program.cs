Console.WriteLine("1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.");
Console.WriteLine("2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.");
Console.WriteLine("3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
Console.Write("4. Вклад в банке составляет X рублей. Ежегодно он увеличивается на P процентов, после чего дробная часть копеек отбрасывается. ");
Console.WriteLine("Требуется определить: через сколько лет вклад составит не менее Y рублей.");
Console.WriteLine("5. В первый день спортсмен пробежал X километров. В каждый последующий день он увеличивал пробег на 15% от предыдущего дня. По данному числу Y требуется определить номер дня, в который пробег спортсмена составил не менее Y километров.");

Console.Write("Введите номер задачи ");

int TaskNumber = Convert.ToInt32(Console.ReadLine());

while (TaskNumber <= 0 || TaskNumber >= 6)
{
    Console.Write("Выберете задачу 1 - 5: ");
    TaskNumber = Convert.ToInt32(Console.ReadLine());
}

if (TaskNumber == 1)
{
    Task1();
}

if (TaskNumber == 2)
{
    Task2();
}

if (TaskNumber == 3)
{
    Task3();
}

if (TaskNumber == 4)
{
    Task4();
}

if (TaskNumber == 5)
{
    Task5();
}

void Task1()
{
    int a;
    Console.Write("Введите трехзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    while (Convert.ToString(a).Length != 3)
    {
        Console.Write("Данное число не трехзначное, повторите ввод: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine(Convert.ToString(a)[1]);
}

void Task2()
{
    int a;
    Console.Write("Введите число: ");
    a = Convert.ToInt32(Console.ReadLine());
    if (Convert.ToString(a).Length <= 2)
        Console.WriteLine("третьей цифры нет");
    else
        Console.WriteLine(Convert.ToString(a)[2]);
}

void Task3()
{
    int a;
    Console.Write("Введите цифру, обозначающую день недели (от 1 до 7): ");
    a = Convert.ToInt32(Console.ReadLine());
    while (a < 1 || a > 7)
    {
        Console.Write("Данная цифра не обозначает день недели, повторите ввод: ");
        a = Convert.ToInt32(Console.ReadLine());
    }
    if (a == 6 || a == 7)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

void Task4()
{
    int x, p, y, result;
    int countYear = 0;
    Console.Write("Введите сумму вклада: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите процент по вкладу: ");
    p = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ожидаемую сумму: ");
    y = Convert.ToInt32(Console.ReadLine());
    result = x;

    while (result < y)
    {
        result = result * (100 + p) / 100;
        countYear++;
    }

    Console.WriteLine(countYear);
}

void Task5()
{
    int x, y;
    double result;
    int countDay = 1;
    Console.Write("Введите пробег спротсмена за первый день: ");
    x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите ожидаемый пробег: ");
    y = Convert.ToInt32(Console.ReadLine());
    result = x;

    while (result < y)
    {
        result = result * 1.15;
        countDay++;
    }

    Console.WriteLine(countDay);
}