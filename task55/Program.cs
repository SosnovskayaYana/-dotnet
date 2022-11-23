/* Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя. */

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


int[,] RepleaceRowsColumns(int[,] array2d)
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


int[,]newMatrix = CreateMatrixRndInt(4, 4, 0, 10);
PrintMatrix(newMatrix);
Console.WriteLine("");

if(newMatrix.GetLength(0) == newMatrix.GetLength(1))
{
int[,] repleaceRowsColumns = RepleaceRowsColumns(newMatrix);
PrintMatrix(repleaceRowsColumns);
}

else Console.WriteLine("Невозможно заменить строки на столбцы ");