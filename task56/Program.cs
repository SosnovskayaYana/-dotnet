/* Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и 
выдаёт номер строки с наименьшей суммой элементов: 1 строка */


int[,] GetArray(int m, int n, int min, int max)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] array2D)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            Console.Write(array2D[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int RowsMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowsSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowsSum += array[i, j];
        }

        if (rowsSum < minSum)
        {
            minSum = rowsSum;
            index = i + 1;
        }
    }

    return index;
}



int[,] matrixArray = GetArray(3, 4, 1, 5);
PrintMatrix(matrixArray);

Console.WriteLine();

int rowsMinSum = RowsMinSum(matrixArray);
Console.WriteLine($"номер строки с наименьшей суммой элементов: {rowsMinSum} ");