/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = rnd.Next(min, max + 1);
        } 
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if(j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} |");
            else Console.Write($"{matrix[i,j],5}");
        }
        Console.WriteLine("]");
    }
}


void RepleaceRows(int[,] matrixA)
{
for (int i = 0; i < matrixA.GetLength(1); i++)
{
        int temp = matrixA[0, i];
        matrixA[0, i] = matrixA[matrixA.GetLength(0) - 1, i];
        matrixA[matrixA.GetLength(0) - 1, i] = temp;
}
}


int[,]newMatrix = CreateMatrixRndInt(5, 5, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("");
RepleaceRows(newMatrix);
PrintMatrix(newMatrix);