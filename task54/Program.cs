// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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


/// сортировка матрицы по убыванию
void SortElemens (int [,] matrixSort)
{
    for (int i = 0; i < matrixSort.GetLength(0); i++)
    {
        for (int j = 0; j < matrixSort.GetLength(1); j++)
        {
            for (int k = 0; k < matrixSort.GetLength(1) - 1; k++)
            {
                if (matrixSort[i, k] < matrixSort[i, k + 1])
                {
                    int temp = matrixSort[i, k + 1];
                    matrixSort[i, k + 1] = matrixSort[i, k];
                    matrixSort[i, k] = temp;
                }
            }
        }
    }

}


int[,] matrixArray = GetArray(5, 5, 0, 10);
PrintMatrix(matrixArray);

Console.WriteLine();
Console.WriteLine("Результат: ");
Console.WriteLine();

SortElemens(matrixArray);
PrintMatrix(matrixArray);