/* Задайте значения M и N. Напишите программу, которая выведет все
чётные натуральные числа в промежутке от M до N с помощью рекурсии.
M = 1; N = 5 -> 2, 4
M = 4; N = 8 -> 4, 6, 8  */

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

void EvenNumbers(int m, int n, int even)
{
    if (m > n)
    {
        return;
    }
    if (even % 2 == 0)
    {
        EvenNumbers(m, n, even + 2);
        Console.Write($"Четные натуральные числа в промежутке от {m} до {n}: {even} + ", "");
    }

}



