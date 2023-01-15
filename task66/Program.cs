// Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите положительное число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите положительное число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма элементов: {NaturalSum(M, N)}");
int NaturalSum(int M, int N)
{
    if (M == N)
        return N;
    return N + NaturalSum(M, N - 1);
}