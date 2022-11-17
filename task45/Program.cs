/* программa, которая будет создавать
копию заданного массива с помощью поэлементного
копирования.  */

int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] array1)
{
    int[] newArray = new int[array1.Length];
    for (int i = 0; i < array1.Length; i++)
    {
        newArray[i] = array1[i];
    }
    return newArray;
}


int[] arr = CreateArrayRndInt(5, 1, 9);
PrintArray(arr);

int[] copyArray = CopyArray(arr);
// copyArray[2] = 20;
PrintArray(copyArray);
