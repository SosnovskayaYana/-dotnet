/*  Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.

1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} | ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine(" |");
    }
}


void PrintArray2(double[] array)
{
    Console.Write("");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("");
}


double[] ArithmeticMean(int[,] matrixArray)
{
    int columnsCount = matrixArray.GetLength(1);
    double[] result = new double[columnsCount];

    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        for (int i = 0; i < matrixArray.GetLength(0); i++)
        {
            result[j] = result[j] + matrixArray[i, j];
        }

        result[j] = Math.Round(result[j] / (double)matrixArray.GetLength(0), 1);
    }

    return result;
}


int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);  // вызов матрицы
PrintMatrix(array2D);

Console.WriteLine();

double[] arithmeticMean = ArithmeticMean(array2D);
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintArray2(arithmeticMean);
