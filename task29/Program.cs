// программa, задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]



int[] ArrayDigit(int[] arrayFirst)
{
    // Random rnd = new Random();
    for (int i = 0; i < arrayFirst.Length; i++)
    {
        // arrayFirst[i] = rnd.Next(0, 99);
        arrayFirst[i] = new Random().Next(0, 100);
    }
    return arrayFirst;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(",");
    }
    Console.Write("]");
}


Console.WriteLine("Программa, задаёт массив из 8 элементов и выводит их на экран. ");

int size = 8;
int[] arrayDigit = new int[size];

arrayDigit = ArrayDigit(arrayDigit);
PrintArray(arrayDigit);