/* Задайте двумерный массив размером m×n,
заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1  */


            // метод создает двумерный массив с рандомными числами
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

        // метод вывода матрицы, двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 5} | ");
            else Console.Write($"{matrix[i,j], 5} ");
        }
        Console.WriteLine(" |");
    }
}


int[,] array2D = CreateMatrixRndInt(3, 4, -10, 100);  // вызов матрицы
PrintMatrix(array2D);


/*  Решение без метода.  С ЛИТЕРАЛАМИ в выводе

Console.WriteLine("Введите количество строк ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[rows, columns];


for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(10, 100);
        Console.Write(matrix[i,j] + "\t");       // ЛИТЕРАЛ "\t" - отступ
    }
    Console.WriteLine();
}
*/