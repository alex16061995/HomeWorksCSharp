Console.WriteLine("1. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");
Console.WriteLine("2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");
Console.WriteLine("3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
Console.Write("4. Задана последовательность натуральных чисел, завершающаяся числом 0. ");
Console.WriteLine("Требуется определить значение второго по величине элемента в этой последовательности, то есть элемента, который будет наибольшим, если из последовательности удалить наибольший элемент.");

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
    Console.Write("Введите пятизначное число ");
    int n = Convert.ToInt32(Console.ReadLine());

    while (n < 10000 || n > 99999)
    {
        Console.Write("Число не пятизначное, повторите ввод ");
        n = Convert.ToInt32(Console.ReadLine());
    }
    string row = Convert.ToString(n);
    int i = 0;
    bool palindrom = true;

    while (i < 2)
    {
        if (row[i] == row[4 - i])
            i++;
        else
        {
            palindrom = false;
            i++;
        }
    }

    if (palindrom)
        Console.WriteLine("Yes");
    else
        Console.WriteLine("No");
}

void Task2()
{
    Console.Write("x1 = ");
    int x1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y1 = ");
    int y1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z1 = ");
    int z1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("x2 = ");
    int x2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("y2 = ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("z2 = ");
    int z2 = Convert.ToInt32(Console.ReadLine());

    double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    Console.WriteLine(result);
}

void Task3()
{
    Console.Write("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    int i = 1;

    while (i <= n)
    {
        Console.Write(Math.Pow(i, 3) + " ");
        i++;
    }
}

void Task4()
{
    int[] array = new int[10];
    int i = 0;
    Console.WriteLine("Заполните числовую последовательность из 10 чисел");
    while (i < array.Length)
    {
        Console.Write("Число " + Convert.ToString(i + 1) + (": "));
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    int max = FirstMaxArrayNum(array);
    SecondMaxArrayNum(array, max);

}

int FirstMaxArrayNum(int[] collection)
{
    int i = 0;
    int max = collection[0];
    while (i < collection.Length)
    {
        if (collection[i] != 0)
            {
                if (collection[i] > max)
                    {
                        max = collection[i];
                        i++;
                    }
                else
                    i++;
            }
        else
            break;
    }
    return max;
}

void SecondMaxArrayNum(int[] array, int FirstMaxValue)
{
    int i = 0;
    int max = array[0];
    while (i < array.Length)
    { 
        if (array[i] != 0)
        {
            if (array[i] > max && array[i] != FirstMaxValue)
            {
                max = array[i];
                i++;
            }
            else
                i++;
        }
        else
            break;
    }
    if (max == FirstMaxValue) Console.WriteLine("Второго максимального числа в последовательности до 0 нету");
    else Console.WriteLine(max);
}