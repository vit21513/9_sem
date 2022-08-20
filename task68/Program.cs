//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

//             _
//            |  если m=0  то  n+1 
//A(m,n) =    |  если m != 0 n=0 A(n-1,1) 
//            |  если m>0 n>0 A(m-1,A(m,n-1))) 
//            |__

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

int Akkerman (int m, int n)
{
    if (m==0) return n+1;
    else if (n==0) return Akkerman(m-1,1);
    else return Akkerman(m-1,Akkerman(m,n-1));
   
}

int m = InputNumbers("Введите введите  первое  число M ");
int n = InputNumbers("Введите второе число N  ");
int funcAkkerman = Akkerman(m, n);
Console.WriteLine($"Функция Аккермана чисел {m} и {n} составляет {funcAkkerman}");

//m = 2, n = 3 -> A(m,n) = 29 В примере на сайте не верно указано при  m = 2, n = 3 -> A(m,n) = 9 !!!    m = 3, n = 2  A(m,n) = 29