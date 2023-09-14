/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


System.Console.WriteLine(FindSumNumbers(4, 8));

int FindSumNumbers(int m, int n)
{
    if (m > n)
    {
        return 0;
    }
    else
    {
        int result = m + FindSumNumbers(m + 1, n);
        return result;
    }
}