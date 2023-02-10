/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18             Матрицу P можно умножить на матрицу K только в том случае, если число столбцов матрицы P
                  равняется числу строк матрицы K. Матрицы, для которых данное условие не выполняется, 
                  умножать нельзя. */

int Prompt(string message)
{
    Console.Write($"{message}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int rows = Prompt("Введите количество строк");
int columns = Prompt("Введите количество столбцов");
int[,] matrix = new int[rows, columns]; //1-я матрица
int[,] secondMatrix = new int[rows, columns]; //2-я матрица
int[,] resultMatrix = new int[rows, columns]; //матрица - результат перемножения двух матриц

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

void GetMultplicationMatrix(int[,] resultMatrix)
{
    if (matrix.GetLength(0) != secondMatrix.GetLength(1))
    {
        Console.WriteLine("Матрицы нельзя перемножить");
        Console.WriteLine();
        return;
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            resultMatrix[i, j] = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += matrix[i, k] * secondMatrix[k, j];
            }
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

FillMatrix(matrix);
Console.WriteLine("\nМатрица № 1:");
PrintMatrix(matrix);
FillMatrix(secondMatrix);
Console.WriteLine("\nМатрица № 2:");
PrintMatrix(secondMatrix);
Console.WriteLine("\nПроизведение первой и второй матриц:");
GetMultplicationMatrix(resultMatrix);
PrintMatrix(resultMatrix);

