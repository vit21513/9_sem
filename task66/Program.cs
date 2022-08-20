//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();

int n = InputNumbers("Введите введите  первое  число ");
int m = InputNumbers("Введите второе число ");
int summa = SummNum(n, m);
Console.WriteLine($"Сумма элементов от {n} до {m} составляет {summa}");

int SummNum(int n, int m)
{
    if (n == m) return n;
    if (n < m) return n + SummNum(n + 1, m);
    else return m + SummNum(n, m + 1);
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}
