Console.WriteLine("1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("3. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.");
Console.WriteLine("4. Задана последовательность натуральных чисел, завершающаяся числом 0. Требуется определить наименьшее расстояние между двумя локальными максимумами последовательности натуральных чисел, завершающейся числом 0.");
Console.WriteLine("5. Напишите программу для нахождения максимального числа ягод, которое может собрать за один заход собирающий модуль, находясь перед некоторым кустом заданной во входном файле грядки.");

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
    Console.Write("Введите первое число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число: ");
    int b = Convert.ToInt32(Console.ReadLine());
    int i = 2;
    int result = a;

    while(i <= b)
    {
        result = result * a;
        i++;
    }
    Console.WriteLine(result);
}

void Task2()
{
    Console.Write("Введите число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    int sum = 0;

    while (a != 0)
    {
        sum = sum + a % 10;
        a = (a - a % 10) / 10;
    }

    Console.WriteLine("Сумма цифр в числе = " + sum);
}

void Task3()
{
    int[] array = new int[8];
    int i = 0;
    Console.WriteLine("Заполните числовую последовательность из 8 элементов");
    while (i < array.Length)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + (": "));
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void Task4()
{
    Console.Write("Число 1: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int temp1 = n;
    Console.Write("Число 2: ");
    n = Convert.ToInt32(Console.ReadLine());
    int temp2 = n;
    int result = 0;
    int FirstLocalMaxPosition = 1;
    int SecondLocalMaxPosition = 1;
    int counter = 3;

    while (n != 0)
    {
        Console.Write("Число " + counter + ": ");
        n = Convert.ToInt32(Console.ReadLine());
        if (temp2 > temp1 && temp2 > n)
        {
            if (FirstLocalMaxPosition == 1)
            {
                FirstLocalMaxPosition = counter;
            }
            else
            {
                if (SecondLocalMaxPosition == 1)
                {
                    SecondLocalMaxPosition = counter;
                    result = SecondLocalMaxPosition - FirstLocalMaxPosition;
                }
                else
                {
                    FirstLocalMaxPosition = SecondLocalMaxPosition;
                    SecondLocalMaxPosition = counter;
                    if (SecondLocalMaxPosition - FirstLocalMaxPosition < result)
                    {
                        result = SecondLocalMaxPosition - FirstLocalMaxPosition;
                    }
                }
            }
        }
        temp1 = temp2;
        temp2 = n;
        counter++;
    }

    Console.WriteLine("Наименьшее расстояние между двумя локальными максимумами = " + result);
}

void Task5()
{
    Console.Write("Введите количество кустов (больше 2): ");
    int n = Convert.ToInt32(Console.ReadLine());
    int result = 0;

    while (n < 3)
    {
        Console.Write("Повторите ввод (больше 2): ");
        n = Convert.ToInt32(Console.ReadLine());
    }

    int[] array = new int[n];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + (": "));
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("[" + string.Join(", ", array) + "]");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0)
        {
            result = array[array.Length - 1] + array[i] + array[i + 1];
        }
        else
        {
            if (i == array.Length - 1)
            {
                if (array[i - 1] + array[i] + array[0] > result)
                {
                    result = array[i - 1] + array[i] + array[0];
                }
            }
            else
            {
                if (array[i - 1] + array[i] + array[i + 1] > result)
                {
                    result = array[i - 1] + array[i] + array[i + 1];
                }
            }
        }
    }
    
    Console.WriteLine("Максимальное числа ягод, которое может собрать за один заход собирающий модуль = " + result);
}
