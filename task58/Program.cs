/* Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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


int [,] SquareMatrix(int [,] array1, int [,] array2)
{
    int [,] matrixResult = new int [array1.GetLength(0), array2.GetLength(1)];

for (int i = 0; i < array1.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        matrixResult[i, j] = 0;
        for (int k = 0; k < array2.GetLength(0); k++)
        {
            matrixResult[i, j] = matrixResult[i, j] + array1[i, k] * array2[k, j];
        }
    }
}
    return matrixResult;
}


int[,] matrixArray1 = GetArray(2, 2, 1, 5);
Console.WriteLine("Первая матрица: ");
PrintMatrix(matrixArray1);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] matrixArray2 = GetArray(2, 2, 6, 10);
PrintMatrix(matrixArray2);
Console.WriteLine();


if (matrixArray1.GetLength(1) == matrixArray2.GetLength(0)) // число столбцов матрицы P == числу строк матрицы K
{ 

Console.WriteLine("Результат: ");

int[,] matrixArrayResult = SquareMatrix(matrixArray1, matrixArray2);
PrintMatrix(matrixArrayResult);

}

else Console.WriteLine("Матрицу 1 нельзя умножить на матрицу 2 ");