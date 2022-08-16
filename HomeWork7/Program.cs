Console.WriteLine("1. Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");
Console.WriteLine("2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.");
Console.WriteLine("3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.WriteLine("4. Задана целочисленная матрица, состоящая из N строк и M столбцов. Требуется транспонировать ее относительно горизонтали.");

Console.Write("Введите номер задачи ");

int TaskNumber = Convert.ToInt32(Console.ReadLine());

while (TaskNumber <= 0 || TaskNumber >= 5)
{
    Console.Write("Выберете задачу 1 - 4: ");
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

void Task1()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().NextDouble() * new Random().Next(-20, 21);
            Console.Write(Math.Round(array[i, j], 2) + "\t");
        }
        Console.WriteLine();
    }
}

void Task2()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.Write("Введите номер строки искомого значения: ");
    int rowCount = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите номер столбца искомого значения: ");
    int colCount = Convert.ToInt32(Console.ReadLine());

    if (rowCount > m || colCount > n)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine("Искомое значение: " + array[rowCount - 1, colCount - 1]);
    }
}

void Task3()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Среднее арифметическое элементов в каждом столбце");

    double result;
    int count;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        result = 0;
        count = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            result = result + array[i, j];
            count++;
        }
        Console.Write(Math.Round(result / count, 2) + "\t");
    }
}

void Task4()
{
    Console.Write("Введите число строк массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число столбцов массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp;

    Console.WriteLine("Исходная матрица: ");

    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    Console.WriteLine("Транспонированная относильно горизонтали матрица: ");

    for (int i = 0; i < array.GetLength(0)/2; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            temp = array[i, j];
            array[i, j] = array[array.GetLength(0) - 1 - i, j];
            array[array.GetLength(0) - 1 - i, j] = temp;
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
             Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
