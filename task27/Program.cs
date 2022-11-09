// программa, принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// num = Math.Abs(num);
// int sum = 0;

// while (num > 0)
// {
//     sum = sum + num % 10;
//     num = num / 10;
// }

// Console.WriteLine($"{sum}");


int SumDigit(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

number = Math.Abs(number);

int sumDigit = SumDigit(number);

Console.WriteLine($"Сумма цифр в числе {number} равна {sumDigit} ");
