/* Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива. */

/*
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
*/


// Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


/// summary - описание метода, через тройной слэш
/// матрица: m на n, m - кол-во строк, n - кол-во столбцов
/// minValue, maxValue - числа для рандома

int[,] GetArray(int m, int n, int minValue, int maxValue)  // (int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)  // m - кол-во строк
    {
        for (int j = 0; j < n; j++)  // n - кол-во столбцов
        {
            matrix[i, j] = rnd.Next(minValue, maxValue + 1);  // matrix[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matrix;
}


/// печатает матрицу
void PrintMatrix(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i, j] + "\t");
        }

        Console.WriteLine();
    }
}


int[,] matrixArray = GetArray(rows, columns, 0, 10);
PrintMatrix(matrixArray);


void ChangeRows(int[,] matrix)
{
    int indexLastRow = matrix.GetLength(0) - 1;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = matrix[0, j];
        matrix[0, j] = matrix[indexLastRow, j];
        matrix[indexLastRow, j] = temp;
    }
}


ChangeRows(matrixArray);
Console.WriteLine("");
Console.WriteLine("Результат: ");
Console.WriteLine("");
PrintMatrix(matrixArray);