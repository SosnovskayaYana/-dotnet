/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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


int[,] RepleaceRowsToColumns(int[,] array2d)
{
    int[,] newArray2D = new int[array2d.GetLength(0), array2d.GetLength(1)];
for (int i = 0; i < array2d.GetLength(0); i++)
{
    for (int j = 0; j < array2d.GetLength(1); j++)
    {
        newArray2D[i, j] = array2d[j,i];
    }
}
return newArray2D;
}

/*
int[,] ReplaceRowsToColumns(int[,] matrix)
{
for (int i = 0; i < matrix.GetLength(0); i++)
{
for (int j = i; j < matrix.GetLength(1); j++)
{
int temp = matrix[i, j];
matrix[i, j] = matrix[j, i];
matrix[j, i] = temp;
}
}
return matrix;
}
*/

/*
int[,]newMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("");

if(newMatrix.GetLength(0) == newMatrix.GetLength(1))
{
int[,] repleaceRowsToColumns = RepleaceRowsToColumns(newMatrix);
PrintMatrix(repleaceRowsToColumns);
}

else Console.WriteLine("Невозможно заменить строки на столбцы ");  
*/


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());


int[,] GetArray(int m, int n, int min, int max)  // (int m, int n, int minValue, int maxValue)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)  // m - кол-во строк
    {
        for (int j = 0; j < n; j++)  // n - кол-во столбцов
        {
            matrix[i, j] = rnd.Next(min, max + 1);  // matrix[i, j] = new Random().Next(minValue, maxValue + 1);
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

int[,] ReplaceRowsColumns(int[,] array)
{
    int[,] replaceArray = new int[array.GetLength(0), array.GetLength(1)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                replaceArray[i, j] = array[j, i];
            }
        }

    return replaceArray;
}



int[,] matrixArray = GetArray(rows, columns, 0, 10);
PrintMatrix(matrixArray);

Console.WriteLine();
Console.WriteLine("Результат: ");

if (rows == columns)
{
int[,] replace = ReplaceRowsColumns(matrixArray);

Console.WriteLine();

PrintMatrix(replace);
}

else Console.WriteLine("Невозможно заменить строки на столбцы ");