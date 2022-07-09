Console.WriteLine("1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.");
Console.WriteLine("2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.");
Console.WriteLine("3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).");
Console.WriteLine("4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.");

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
    Console.Write("Введите первое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a > b && a != b)
    {
        Console.WriteLine("Наибольшее число: " + a);
        Console.WriteLine("Наименьшее число: " + b);
    }

    if (a < b && a != b)
    {
        Console.WriteLine("Наибольшее число: " + b);
        Console.WriteLine("Наименьшее число: " + a);
    }

    if (a == b)
    {
        Console.WriteLine("Числа равны");
    }
}

void Task2()
{
    Console.Write("Введите первое число ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе число ");
    int b = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье число ");
    int c = Convert.ToInt32(Console.ReadLine());

    int max = a;

    if (b > max)
        max = b;
    if (c > max)
        max = c;

    Console.WriteLine("Максимальное число: " + max);
   
}

void Task3()
{
    Console.Write("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (n % 2 ==0)
        Console.WriteLine("Число четное");
    else
        Console.WriteLine("Число нечетное");
}

void Task4()
{
    Console.Write("Введите число ");
    int n = Convert.ToInt32(Console.ReadLine());
    int count = 1;

    while (count <= n)
    {
        if (count % 2 == 0)
            Console.Write(count + " ");
        count ++;
    }    
}
