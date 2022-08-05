Console.WriteLine("1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.");
Console.WriteLine("2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine("3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.");

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
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        if (array[i] % 2 == 0) count++;
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Количество чётных чисел в массиве: " + count);
}

void Task2()
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
        if (i % 2 != 0) sum = sum + array[i];
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
}

void Task3()
{
    Console.Write("Введите размерность массива: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число "+ Convert.ToString(i+1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    int max = array[0];
    int min = array[0];

     for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
    Console.WriteLine("Разница между максимальным и минимальным элементов массива " + Convert.ToString(max - min));
}
