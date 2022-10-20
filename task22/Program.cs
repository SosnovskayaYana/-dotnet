// программуa принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.


Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void SquareTable(int num)
{
    if (num > 0)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine($"|{i,4} | {i * i,4}|");
        }
    }
    else
    {
        Console.WriteLine("Введите значение больше 0");
    }
}

SquareTable(n);



/*
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int x)
{
    int count = 1;
    int result = 1;
    while (x >= count)
    {
        result = count * count;
        System.Console.WriteLine($"Для числа {count} квадрат = {result}");
        count++;
    }
}

Square(number);
*/
