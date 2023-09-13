// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


System.Console.WriteLine("Задача 64. Вывести все натуральные числа от N до 1 с помощью рекурсии. ");

string PrintNumbers(int num64)
{
    if(num64 == 1)
    {
        return num64.ToString();
    }
    if(num64 > 0)
    {
        return num64 + "; " + PrintNumbers(num64 - 1);
    }
    else
    {
        return num64 + "; " + PrintNumbers(num64 + 1);
    }
}
System.Console.Write("Введите число N: ");
int number64 = int.Parse(Console.ReadLine());
System.Console.WriteLine("N = " + number64 + " -> \"" + PrintNumbers(number64) + "\"");


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

System.Console.WriteLine("Задача 66. Сумма натуральных элементов в промежутке от M до N ");
int SumNumbers(int number660, int number66)
{
    if(number660 == number66)
    {
        return number660;
    }
    if(number660 < number66)
    {
        return number66 + SumNumbers(number660, number66 - 1);
    }
    else
    {
        return number66 + SumNumbers(number660, number66 + 1);
    }
}

System.Console.Write("Введите значение числа M: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите значение числа N: ");
int n = int.Parse(Console.ReadLine());
System.Console.WriteLine($"M = {m}; N = {n} -> {SumNumbers(m, n)}");


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


System.Console.WriteLine("Задача 68. Вычесление функции Аккермана с помощью рекурсии.");
int A(int num680, int num681)
{
    if (num680 == 0) return num681 + 1;
    if (num680 != 0 && num681 == 0) return A(num680 - 1, 1);
    if (num680 > 0 && num681 > 0) return A(num680 - 1, A(num680, num681 - 1));
    return A(num680,num681);
}
bool error = true;
int m68 = 0;
int n68 = 0;
while(error)
{
    System.Console.Write("Введите первое число: ");
    m68 = int.Parse(Console.ReadLine());
    System.Console.Write("Введите второе число: ");
    n68 = int.Parse(Console.ReadLine());
    if(m68 < 0 || n68 < 0)
    {
        System.Console.WriteLine("Ошибка! Оба числа должны быть положительными!");
    }
    else
    {
        error = false;
    }
}

System.Console.Write($"m = {m68}, n = {n68} - > A(m,n) = {A(m68, n68)}");


