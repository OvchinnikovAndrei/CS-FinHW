// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
Console.WriteLine("Введите положительное число N: ");
int N = int.Parse(Console.ReadLine()!);
int M = 1;
string NaturalRec (int M, int N)
{
    if (M == N)
    {
        return N.ToString();
    }
    return (N+" "+NaturalRec(M, N - M));
}
Console.WriteLine(NaturalRec(M,N));