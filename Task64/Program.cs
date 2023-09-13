/*
Задача 64: Задайте значение N. Напишите программу, которая 
выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

System.Console.WriteLine(PrintNumbers(80, 9));

string PrintNumbers(int end, int start)
{
    if (end == start)
    {
        return end.ToString();
    }
    if(end < start)
    {
        return "Числа заданы не верно";
    }
    else
    {
        return end + " " + PrintNumbers(end - 1, start);
    }
}