Console.WriteLine("1. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
Console.WriteLine("2. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
Console.WriteLine("3. Задана целочисленная квадратная матрица размером N x N. Требуется транспонировать ее относительно главной диагонали.");

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
    Console.Write("Введите размерность последовательности: ");
    int m = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int[] array = new int[m];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + " ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) count++;
    }
    Console.WriteLine("чисел больше нуля: " + count);
}

void Task2()
{
    Console.Write("b1 = ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k1 = ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("b2 = ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("k2 = ");
    double k2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(b2 - b1);
    Console.WriteLine(k1 - k2);

    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;

    Console.WriteLine("( " + x + " , " + y + " )");
}

void Task3()
{
    Console.Write("Введите строк и столбцов: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[n,n];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
            Console.Write($"{array[i, j]} ");   
        }
        Console.WriteLine();
    }
    
    Console.WriteLine("Транспонированный массив: ");
    TranspositionArray(array);

}

void TranspositionArray(int[,] arrayTr)
{
    int temp = arrayTr[0,0];

    for (int i = 0; i < arrayTr.GetLength(0); i++)
    {
        for (int j = 0; j < i; j++)
        {
            temp = arrayTr[i, j];
            arrayTr[i, j] = arrayTr[j, i];
            arrayTr[j, i] = temp;
        }
    }
    
    for (int i = 0; i < arrayTr.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTr.GetLength(1); j++)
        {
            Console.Write($"{arrayTr[i, j]} "); 
        }
         Console.WriteLine();
    }

}
