
/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/


/// метод создает трехмерный массив, заполненый числами от 10 и выше
int[,,] GetArray3D(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int count = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = count;
                count++;
            }
        }
    }
    return matrix;
}


/// метод вывода трехмерной матрицы с указанием индексов
void PrintMatrix3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                if (k < array3D.GetLength(2) - 1)
                    Console.Write($"{array3D[i, j, k],5} ({i},{j},{k})");
                else Console.Write($"{array3D[i, j, k],5} ({i},{j},{k})");
            }

        }
        Console.WriteLine();
    }
}


int[,,] matrixArray3D = GetArray3D(2, 2, 2);

PrintMatrix3D(matrixArray3D);
Console.WriteLine();


