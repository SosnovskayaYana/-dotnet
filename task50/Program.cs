/* программa, на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента 
или указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого элемента в массиве нет */


int[,] array2D = CreateMatrixRndInt(4, 4, -1000, 1000);  // вызов матрицы
PrintMatrix(array2D);
Console.WriteLine("");

Console.Write("Введите номер строки: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int n = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($" {array2D[m - 1, n - 1]} ");
Console.WriteLine("");
FindPosicionElem(array2D);



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


void FindPosicionElem(int[,] matrix)
{
    if (m > 0 && m <= matrix.GetLength(0) && n > 0 && n <= matrix.GetLength(1))
    {
        Console.WriteLine($" {matrix[m-1, n-1]} ");
    }
    else Console.WriteLine("такого элемента в массиве нет ");
}


