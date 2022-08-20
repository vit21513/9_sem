//Задача 64: Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> ""1, 2, 3, 4, 5""
//M = 4; N = 8. -> ""4, 6, 7, 8""

Console.Write("Задайте число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num) //5 4 3 2 1
{
    if(num == 0) return;
    Console.Write($"{num} ");
    NaturalNumber(num - 1);
    
}

NaturalNumber(number);
