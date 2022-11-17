/* Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3 */


void ArrayPersonal(int[] newArray)
{
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        newArray[i] = num;
    }
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}


int CountPositiveArray(int[] countArray)
{
    int count = 0;
    for (int i = 0; i < countArray.Length; i++)
    {
        if (countArray[i] > 0) count = count + 1;
    }
    return count;
}


Console.Write("Укажите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];

ArrayPersonal(array);
Console.WriteLine(" ");

PrintArray(array);

int countPositiveArray = CountPositiveArray(array);
Console.Write($"Количество положительных чисел в массиве = {countPositiveArray} ");