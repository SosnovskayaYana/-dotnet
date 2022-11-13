// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементом массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2



//        метод создает массив со случайными вещественными числами
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 1);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}; ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxElemArray(double[] arrayMaxElem)  // метод поиска мин элемента
{
    double max = arrayMaxElem[0];

    for (int i = 0; i < arrayMaxElem.Length; i++)
    {
        if (arrayMaxElem[i] > max) max = arrayMaxElem[i];

    }
    return max;
}

double MinElemArray(double[] arrayMinElem)  // метод поиска мах элемента
{
    double min = arrayMinElem[0];

    for (int i = 0; i < arrayMinElem.Length; i++)
    {
        if (arrayMinElem[i] < min) min = arrayMinElem[i];

    }
    return min;
}

double DiffMaxMinElem(double mx, double mn)
{
    double diff = mx - mn;
    return diff;
}


double[] array = CreateArrayRndDouble(5, 1, 20);
PrintArray(array);

double maxElemArray = MaxElemArray(array);
Console.WriteLine($"max = {maxElemArray}");

double minElemArray = MinElemArray(array);
Console.WriteLine($"min = {minElemArray}");

double diffMaxMinElem = DiffMaxMinElem(maxElemArray, minElemArray);
Console.WriteLine($"Разница между {maxElemArray} и {minElemArray} = {diffMaxMinElem}");