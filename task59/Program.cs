// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

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


int[,] matrixArray = GetArray(5, 5, 3, 20);
PrintMatrix(matrixArray);

Console.WriteLine();
Console.WriteLine("Результат: ");
Console.WriteLine();

int minNumber = int.MaxValue;

int indexRow = 0;
int indexCol = 0;

for (int i = 0; i < matrixArray.GetLength(0); i++)
{
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        if (minNumber > matrixArray[i, j])
        {
            minNumber = matrixArray[i, j];
            indexRow = i;
            indexCol = j;
        }
    }
}

void PrintNewArray(int[,] inputArray)
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if (i == indexRow) continue;           // останавливает
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (j == indexCol) continue;       // останавливает
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine($"Минимальный элемент: {minNumber}");
Console.WriteLine();


PrintNewArray(matrixArray);