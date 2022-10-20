// программa, принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125


void Cube(int num)
{
    double count = 1;
    double result = 1;

    for (count = 1; num >= count; count++)
    {
        result = Math.Pow(count, 3);
        Console.WriteLine($"| {count,4} | {result,4} |");
    }
}


System.Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Cube(number);
}

else
    Console.WriteLine("Введите значение больше 0");




    // while (num >= count)
    // {
    //     // result = count * count * count;
    //     result = Math.Pow(count, 3);
    //     Console.WriteLine($"| {count, 4} | {result, 4} |");
    //     count++;
    // }