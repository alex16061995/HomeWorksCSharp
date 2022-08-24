Console.WriteLine("1. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
Console.WriteLine("2. Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
Console.WriteLine("3. Дана строка, состоящая из N попарно различных символов. Требуется вывести все перестановки символов данной строки.");

Console.Write("Введите номер задачи ");

int TaskNumber = Convert.ToInt32(Console.ReadLine());

while (TaskNumber <= 0 || TaskNumber >= 4)
{
    Console.Write("Выберете задачу 1 - 3: ");
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

void Task1()
{
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    if (m < n)
        Console.WriteLine(f(m, n));
    else
        Console.WriteLine(f(n, m));
}

int f(int m, int n)
{
    if (n == m)
        return m;

    return f(m, n - 1) + n;
}

void Task2()
{
    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(a(m, n));
}

int a(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return a(m - 1, 1);

    return a(m - 1, a(m, n - 1));
}

void Task3()
{
    Console.Write("Введите длинну последовательности: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int tempIndex = 0;
    string[] array = new string[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Символ " + (i + 1) + ": ");
        array[i] = Console.ReadLine();
    }

    Console.WriteLine("[" + string.Join(", ", array) + "]");

    Console.WriteLine("Все перестановки символов данной строки:");

    p(array, tempIndex);
}

void p(string[] array, int tempIndex)
{
    string temp;
    if (tempIndex == array.Length - 1)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");                   
        }
        Console.WriteLine();         
    }
    else
    {
        for (int j = tempIndex; j < array.Length; j++)
        {
            temp = array[tempIndex];
            array[tempIndex] = array[j];
            array[j] = temp;
            tempIndex++;
            p(array, tempIndex);
            tempIndex--;
            temp = array[tempIndex];
            array[tempIndex] = array[j];
            array[j] = temp;
        }
    }



}
