/* Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1, 7 -> такого числа в массиве нет
1, 2 -> 4 */


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = new int[5, 7];
FillMatrix(matrix);
PrintMatrix(matrix);

int InputInt(string message)
{
  System.Console.Write($"{message}: ");
  return int.Parse(Console.ReadLine());
}

int a = InputInt("Введите номер строки");
int b = InputInt("Введите номер столбца");
if (a < matrix.GetLength(0) && b < matrix.GetLength(1)) 
Console.WriteLine($"Позиция элемента [{a},{b}] равна {matrix[a,b]}");
else Console.WriteLine($"Позиция элемента [{a},{b}] -> такого числа в массиве нет");
