/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.*/


void FillMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 10);
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

void NumberRowMinSumElements(int[,] matrix) // Функция вывода номера строки с наименьшей суммой элементов
{
    int minRow = 0;
    int minSumRow = 0;
    int sumRow = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        minRow += matrix[0, i];
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (sumRow < minRow)
        {
            minRow = sumRow;
            minSumRow = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов {minSumRow + 1} строка");
    Console.WriteLine();
}

int[,] matrix = new int[3, 3];
FillMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
NumberRowMinSumElements(matrix);

